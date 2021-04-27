using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace ProductsAPISampleGenerator
{

    public partial class MainForm : Form
    {

        string strResponse = string.Empty;
        SortedDictionary<string, string> mfrDict;
        SortedDictionary<string, string> productByMfrDict;

        public MainForm()
        {
            InitializeComponent();
        }

        private string SendRequest(string url)
        {
            RestClient rClient = new RestClient();
            rClient.EndPoint = url;
            if (rdoUkKey.Checked)
            {
                return(rClient.MakeRequest(ClientConfig.apiKeyName, ClientConfig.apiUkKeyValue));
            }
            else if (rdoUsKey.Checked)
            {
                return(rClient.MakeRequest(ClientConfig.apiKeyName, ClientConfig.apiUsKeyValue));
            }
            else
            {
                return(rClient.MakeRequest(ClientConfig.apiKeyName, txtAqKeyValue.Text.ToString()));
            }
        }

        private Product DeserializeProductJson(string strJson)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<Product>(strJson);
                return jsonObject;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private MfrBilling DeserializeMfrsJson(string strJson)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<MfrBilling>(strJson);
                return jsonObject;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private ProductsByMfr DeserializeMfrProductsJson(string strJson)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<ProductsByMfr>(strJson);
                return jsonObject;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private string SerializeJson(Object jsonObject)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(jsonObject);
                return jsonString;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        private void DebugOutput(string strDebugText)
        {
            txtResponse.Text = string.Empty;
            System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
            txtResponse.Text += strDebugText;
        }


        private void CmdGetProductList_Click(object sender, EventArgs e)
        {
            List<string> prodIds = txtProdIdList.Text.Split(Environment.NewLine).ToList();
            strResponse = buildJsonStringForProductIds(prodIds);
            DebugOutput(strResponse);
        }

        private void CmdJsonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @Environment.GetFolderPath(Environment.SpecialFolder.Desktop);      
            saveFileDialog1.Title = "Save to JSON file";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "json";
            saveFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                byte[] bytes = Encoding.UTF8.GetBytes(strResponse);
                fs.Write(bytes);
                fs.Close();
            }
        }
        private void cmdChooseMfr_Click(object sender, EventArgs e)
        {
            DebugOutput("Manufacturers found.");
            string mfrsJson = SendRequest(ClientConfig.billingUrl);
            MfrBilling mfrList = DeserializeMfrsJson(mfrsJson);
            checkedListBox1.Items.Clear();
            mfrDict = new SortedDictionary<string,string>();
            foreach (MfrBillingDatum mfr in mfrList.Data)
            {
                mfrDict.Add(mfr.MfrName, mfr.MfrId.ToString());
            }
            foreach (string mfr in mfrDict.Keys) 
            {
                checkedListBox1.Items.Add(mfr);
            }

        }

        private void cmdChooseProds_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                if (mfrDict != null)
                {

                    Boolean mfrFound = false;
                    string selectedMfr = string.Empty;
                    foreach (Object item in checkedListBox1.CheckedItems)
                    {
                        if (mfrFound)
                        {
                            break;
                        }
                        foreach (string mfr in mfrDict.Keys)
                        {
                            if (mfrFound)
                            {
                                break;
                            }
                            if (item.Equals(mfr))
                            {
                                mfrFound = true;
                                selectedMfr = mfr;

                            }
                        }
                    }
                    DebugOutput(selectedMfr + " products found.");
                    string productsjson = SendRequest(ClientConfig.mfrProdsUrl + mfrDict[selectedMfr] + "/products");
                    ProductsByMfr mfrProducts = DeserializeMfrProductsJson(productsjson);
                    checkedListBox2.Items.Clear();
                    productByMfrDict = new SortedDictionary<string,string>();
                    foreach (ProductsByMfrDatum prod in mfrProducts.Data)
                    {
                        productByMfrDict.Add(prod.Models.MfrModel, prod.ProductId.ToString());
                    }
                    foreach (string prod in productByMfrDict.Keys)
                    {
                        checkedListBox2.Items.Add(prod);
                    }
                }
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox.CheckedIndexCollection checkedIndices = checkedListBox1.CheckedIndices;

            if (checkedIndices.Count > 0 && checkedIndices[0] != e.Index)
            {
                checkedListBox1.SetItemChecked(checkedIndices[0], false);
            }
        }

        private void cmdGetSelectedProducts_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count != 0)
            {
                if (productByMfrDict != null)
                {

                    List<string> prodIds = new List<string>();
                    foreach (Object item in checkedListBox2.CheckedItems)
                    {
                        if(productByMfrDict.ContainsKey(item.ToString()))
                        {
                            prodIds.Add(productByMfrDict[item.ToString()]);
                        }
                    }
                    strResponse = buildJsonStringForProductIds(prodIds);
                    DebugOutput(strResponse);
                }
            }
        }

        private string buildJsonStringForProductIds(List<string> prodIds)
        {
            DebugOutput("Building Sample Data");
            string tempString = string.Empty;
            string returnStr = "{\"data\":[";
            foreach (string prodId in prodIds)
            {
                tempString = SendRequest(ClientConfig.prodUrl + prodId);
                Product jsonObjectData = DeserializeProductJson(tempString);
                string newString = SerializeJson(jsonObjectData.Data);
                returnStr += newString;
                returnStr += ",";
            }
            returnStr = returnStr.Remove(returnStr.Length - 1, 1);
            returnStr += "]}";
            return returnStr;
        }


    }
}
