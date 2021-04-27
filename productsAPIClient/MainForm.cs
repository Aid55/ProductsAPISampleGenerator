using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            txtResponse.Text = string.Empty;
            DebugOutput("Rest client created successfully");
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
            DebugOutput("See response below:");
        }

        private Object DeserializeJson(string strJson)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<dynamic>(strJson);
                return jsonObject.data;
                //DebugOutput(jsonObject.ToString());
            }
            catch(Exception ex)
            {
                return ex.Message.ToString();
                //DebugOutput("Deserialization problem" + ex.Message.ToString());
            }
        }

        private MfrBilling DeserializeMfrsJson(string strJson)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<MfrBilling>(strJson);
                return jsonObject;
                //DebugOutput(jsonObject.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
                //DebugOutput("Deserialization problem" + ex.Message.ToString());
            }
        }

        private ProductsByMfr DeserializeMfrProductsJson(string strJson)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<ProductsByMfr>(strJson);
                return jsonObject;
                //DebugOutput(jsonObject.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
                //DebugOutput("Deserialization problem" + ex.Message.ToString());
            }
        }

        private string SerializeJson(Object jsonObject)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(jsonObject);
                return jsonString;
                //DebugOutput(jsonString);
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
                //DebugOutput("Serialization problem" + ex.Message.ToString());
            }
        }

        private void DebugOutput(string strDebugText)
        {
            System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
            txtResponse.Text += strDebugText + Environment.NewLine;
        }

        private void CmdMfrBillingInfo_Click(object sender, EventArgs e)
        {
            strResponse = SendRequest(ClientConfig.billingUrl);
            DebugOutput(strResponse);
        }

        private void CmdMfrProducts_Click(object sender, EventArgs e)
        {
            strResponse = SendRequest(ClientConfig.mfrProdsUrl + txtMfrId.Text + "/products");
            DebugOutput(strResponse);
        }

        private void CmdProduct_Click(object sender, EventArgs e)
        {
            strResponse = SendRequest(ClientConfig.prodUrl + txtProdId.Text);
            DebugOutput(strResponse);
        }

        private void CmdGetProductList_Click(object sender, EventArgs e)
        {
            string[] prodIds = txtProdIdList.Text.Split(Environment.NewLine);
            strResponse = "{\"data\":[";
            string tempString = string.Empty;
            foreach (string prodId in prodIds)
            {
                tempString = SendRequest(ClientConfig.prodUrl + prodId);
                Object jsonObjectData = DeserializeJson(tempString);
                string newString = SerializeJson(jsonObjectData);
                strResponse += newString;
                strResponse += ",";
            }
            strResponse = strResponse.Remove(strResponse.Length - 1, 1);
            strResponse += "]}";
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
            string mfrsJson = SendRequest(ClientConfig.billingUrl);
            MfrBilling mfrList = DeserializeMfrsJson(mfrsJson);
            checkedListBox1.Items.Clear();
            SortedDictionary<string,string> mfrs = new SortedDictionary<string,string>();
            foreach (MfrBillingDatum mfr in mfrList.Data)
            {
                mfrs.Add(mfr.MfrName, mfr.MfrId.ToString());
            }
            foreach (string mfr in mfrs.Keys) 
            {
                checkedListBox1.Items.Add(mfr);
            }

        }

        private void cmdChooseProds_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                string mfrsJson = SendRequest(ClientConfig.billingUrl);
                MfrBilling mfrList = DeserializeMfrsJson(mfrsJson);
                Boolean mfrFound = false;
                string selectedMfr;
                foreach(Object item in checkedListBox1.CheckedItems)
                {
                    if (mfrFound)
                    {
                        DebugOutput("leaving outer loop");
                        break;
                    }
                    foreach (MfrBillingDatum mfr in mfrList.Data)
                    {
                        if (mfrFound)
                        {
                            DebugOutput("Leaving inner loop");
                            break;
                        }
                        if (item.Equals(mfr.MfrName))
                        {
                            DebugOutput("Mfr found" + mfr.MfrName);
                            mfrFound = true;
                            selectedMfr = item.ToString();

                        }
                    }
                }
                string productsjson = SendRequest(ClientConfig.mfrProdsUrl + txtMfrId.Text + "/products");
                ProductsByMfr mfrProducts = DeserializeMfrProductsJson(productsjson);
                checkedListBox2.Items.Clear();
                List<string> products = new List<string>();
                foreach (ProductsByMfrDatum prod in mfrProducts.Data)
                {
                    products.Add(prod.Models.MfrModel);
                }
                products.Sort();
                foreach (string prod in products)
                {
                    checkedListBox2.Items.Add(prod);
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

        }
    }
}
