using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace productsAPIClient
{

    public partial class Form1 : Form
    {

        string strResponse = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void sendRequest(string url)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = url;
            txtResponse.Text = string.Empty;
            debugOutput("Rest client created successfully");
            strResponse = string.Empty;
            if (ClientConfig.apiKeyName == string.Empty || ClientConfig.apiKeyValue == string.Empty)
            {
                strResponse = rClient.makeRequest(txtAqKeyName.Text.ToString(), txtAqKeyValue.Text.ToString());
            }
            else
            {
                strResponse = rClient.makeRequest(ClientConfig.apiKeyName, ClientConfig.apiKeyValue);
            }
            debugOutput("See response below:");
            debugOutput(strResponse);
        }

        private void deserializeJson(string strJson)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<dynamic>(strJson);
                debugOutput(jsonObject.ToString());
            }
            catch(Exception ex)
            {
                debugOutput("Deserialization problem" + ex.Message.ToString());
            }
        }

        private void serializeJson(Object jsonObject)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(jsonObject);
                debugOutput(jsonString);
            }
            catch (Exception ex)
            {
                debugOutput("Serialization problem" + ex.Message.ToString());
            }
        }

        private void debugOutput(string strDebugText)
        {
            System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
            txtResponse.Text += strDebugText + Environment.NewLine;
        }

        private void cmdMfrBillingInfo_Click(object sender, EventArgs e)
        {
            sendRequest(ClientConfig.billingUrl);
        }

        private void cmdMfrProducts_Click(object sender, EventArgs e)
        {
            sendRequest(ClientConfig.mfrProdsUrl + txtMfrId.Text + "/products");
        }

        private void cmdProduct_Click(object sender, EventArgs e)
        {
            sendRequest(ClientConfig.prodUrl + txtProdId.Text);
        }

        private void cmdJsonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\\Users\\AidanBatchelor\\OneDrive - AUTOQUOTES,LLC\\Desktop\\";      
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

    }
}
