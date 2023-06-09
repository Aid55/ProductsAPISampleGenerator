﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private delegate void SafeCallDelegate(string text);
        public MainForm()

        {
            InitializeComponent();
        }

        /// <summary>
        /// Sends a GET request to the URL
        /// </summary>
        /// <param name="url">The URL for the API request</param>
        /// <returns>A JSON data string from the API</returns>
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
                return(rClient.MakeRequest(ClientConfig.apiKeyName, txtKeyValue.Text.ToString()));
            }
        }

        /// <summary>
        /// Turns JSON string into a Product object representing a catalogue product
        /// </summary>
        /// <param name="strJson">JSON string for an API product</param>
        /// <returns>A Product object</returns>
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

        /// <summary>
        /// Turns JSON string into a MfrBilling object representing a list of the mfrs available
        /// </summary>
        /// <param name="strJson">JSON string of the available Mfrs</param>
        /// <returns>A MfrBilling object</returns>
        private Manufacturers DeserializeMfrsJson(string strJson)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<Manufacturers>(strJson);
                return jsonObject;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Turns JSON string into a ProductsByMfr object representing a list of products under a mfr
        /// </summary>
        /// <param name="strJson">JSON string of the products under a mfr</param>
        /// <returns>A ProductsByMfr object</returns>
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

        /// <summary>
        /// Turns a JSON object back into a string
        /// </summary>
        /// <param name="jsonObject">A JSON object</param>
        /// <returns>A JSON string representing the object</returns>
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

        /// <summary>
        /// Outputs the parameter text to the UI
        /// </summary>
        /// <param name="strDebugText">String to print on the UI</param>
        private void DebugOutput(string strDebugText)
        {
            if (txtResponse.InvokeRequired)
            {
                var d = new SafeCallDelegate(DebugOutput);
                txtResponse.Invoke(d, new object[] { strDebugText });
            }
            else
            {
                txtResponse.Text = string.Empty;
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text += strDebugText;
            }
        }

        /// <summary>
        /// Splits the custom product Id's into a List and concatenates them into one string to display on the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdGetCustomProdIds_Click(object sender, EventArgs e)
        {
            if (!bgw_getCustom.IsBusy)
            {
                Cursor.Current = Cursors.WaitCursor;
                List<string> prodIds = txtCustomProdIds.Text.Split(Environment.NewLine).ToList();
                bgw_getCustom.RunWorkerAsync(prodIds);
            }
        }

        private void bgw_getCustom_DoWork(object sender, DoWorkEventArgs e)
        {
            strResponse = buildJsonStringForProductIds((List<string>)e.Argument);
            DebugOutput(strResponse);
        }

        private void bgw_getCustom_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Takes a List object of productId strings, calls the API for each and concatenates all responses into one JSON string
        /// </summary>
        /// <param name="prodIds">List object of productId strings</param>
        /// <returns>A JSON string representing all of the products in the List</returns>
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

        /// <summary>
        /// Gets a list of Mfrs and displays them on the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdChooseMfr_Click(object sender, EventArgs e)
        {
            if (!bgw_getMfrs.IsBusy)
            {
                Cursor.Current = Cursors.WaitCursor;
                DebugOutput("Pulling list of Manufacturers.");
                checkedListBox1.Items.Clear();
                checkedListBox2.Items.Clear();
                bgw_getMfrs.RunWorkerAsync();
            }
        }

        private void bgw_getMfrs_DoWork(object sender, DoWorkEventArgs e)
        {
            string mfrsJson = SendRequest(ClientConfig.manufacturersUrl);
            e.Result = mfrsJson;
        }

        private void bgw_getMfrs_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) 
        {
            Manufacturers mfrList = DeserializeMfrsJson((string)e.Result);
            mfrDict = new SortedDictionary<string,string>();
            foreach (ManufacturersDatum mfr in mfrList.Data)
            {
                mfrDict.Add(mfr.MfrShortName, mfr.MfrId.ToString());
            }
            foreach (string mfr in mfrDict.Keys) 
            {
                checkedListBox1.Items.Add(mfr);
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Gets a list of products for the selected mfr and displays them on the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdChooseProds_Click(object sender, EventArgs e)
        {
            if (!bgw_getProds.IsBusy)
            {
                Cursor.Current = Cursors.WaitCursor;
                if (checkedListBox1.CheckedItems.Count != 0)
                {
                    if (mfrDict != null)
                    {
                        productByMfrDict = new SortedDictionary<string, string>();
                        checkedListBox2.Items.Clear();
                        bgw_getProds.RunWorkerAsync();
                    }
                }
            }
        }

        private void bgw_getProds_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (Object item in checkedListBox1.CheckedItems)
            {
                Boolean mfrFound = false;
                string selectedMfr = string.Empty;
                mfrFound = false;
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
                DebugOutput("Pulling product list for " + selectedMfr + ".");
                string productsjson = SendRequest(ClientConfig.mfrProdsUrl + mfrDict[selectedMfr] + "/products");
                ProductsByMfr mfrProducts = DeserializeMfrProductsJson(productsjson);
                if (mfrProducts.Data != null)
                {
                    foreach (ProductsByMfrDatum prod in mfrProducts.Data)
                    {
                        productByMfrDict.Add(selectedMfr + " " + prod.Models.MfrModel, prod.ProductId.ToString());
                    }
                }
            }
        }

        private void bgw_getProds_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DebugOutput("Finished pulling products");
            foreach (string modelNo in productByMfrDict.Keys)
            {
                checkedListBox2.Items.Add(modelNo);
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Gets the JSON string for each selected product and concatenates them into one string to display on the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdGetSelectedProducts_Click(object sender, EventArgs e)
        {
            if (!bgw_createJson.IsBusy)
            {
                Cursor.Current = Cursors.WaitCursor;
                if (checkedListBox2.CheckedItems.Count != 0)
                {
                    if (productByMfrDict != null)
                    {

                        List<string> prodIds = new List<string>();
                        foreach (Object item in checkedListBox2.CheckedItems)
                        {
                            if (productByMfrDict.ContainsKey(item.ToString()))
                            {
                                prodIds.Add(productByMfrDict[item.ToString()]);
                            }
                        }
                        bgw_createJson.RunWorkerAsync(prodIds);
                        
                    }
                }
                
            }
        }

        private void bgw_createJson_DoWork(object sender, DoWorkEventArgs e)
        {
            strResponse = buildJsonStringForProductIds((List<string>)e.Argument);
            DebugOutput(strResponse);
        }

        private void bgw_createJson_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Exports the JSON string held in the strResponse variable to a JSON file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Limits Mfr selection to 1 Mfr
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //CheckedListBox.CheckedIndexCollection checkedIndices = checkedListBox1.CheckedIndices;
            //
            //if (checkedIndices.Count > 0 && checkedIndices[0] != e.Index)
            //{
            //    checkedListBox1.SetItemChecked(checkedIndices[0], false);
            //}
        }

        /// <summary>
        /// Deselects all boxes in the CheckedListBox parameter
        /// </summary>
        /// <param name="clb"></param>
        private void uncheckAllItems(CheckedListBox clb)
        {
            while (clb.CheckedIndices.Count > 0)
            {
                clb.SetItemChecked(clb.CheckedIndices[0], false);
            }
        }

        /// <summary>
        /// Deselects all Mfrs in the Mfr checklist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdUncheckMfrs_Click(object sender, EventArgs e)
        {
            uncheckAllItems(checkedListBox1);
        }

        /// <summary>
        /// Deselects all Products in the Products checklist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdUncheckProducts_Click(object sender, EventArgs e)
        {
            uncheckAllItems(checkedListBox2);
        }


    }
}
