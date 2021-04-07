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

        private void SendRequest(string url)
        {
            RestClient rClient = new RestClient();
            rClient.EndPoint = url;
            txtResponse.Text = string.Empty;
            DebugOutput("Rest client created successfully");
            strResponse = string.Empty;
            if (ClientConfig.apiKeyName == string.Empty || ClientConfig.apiKeyValue == string.Empty)
            {
                strResponse = rClient.MakeRequest(txtAqKeyName.Text.ToString(), txtAqKeyValue.Text.ToString());
            }
            else
            {
                strResponse = rClient.MakeRequest(ClientConfig.apiKeyName, ClientConfig.apiKeyValue);
            }
            DebugOutput("See response below:");
            DebugOutput(strResponse);
        }

        private void DeserializeJson(string strJson)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<dynamic>(strJson);
                DebugOutput(jsonObject.ToString());
            }
            catch(Exception ex)
            {
                DebugOutput("Deserialization problem" + ex.Message.ToString());
            }
        }

        private void SerializeJson(Object jsonObject)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(jsonObject);
                DebugOutput(jsonString);
            }
            catch (Exception ex)
            {
                DebugOutput("Serialization problem" + ex.Message.ToString());
            }
        }

        private void DebugOutput(string strDebugText)
        {
            System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
            txtResponse.Text += strDebugText + Environment.NewLine;
        }

        private void CmdMfrBillingInfo_Click(object sender, EventArgs e)
        {
            SendRequest(ClientConfig.billingUrl);
        }

        private void CmdMfrProducts_Click(object sender, EventArgs e)
        {
            SendRequest(ClientConfig.mfrProdsUrl + txtMfrId.Text + "/products");
        }

        private void CmdProduct_Click(object sender, EventArgs e)
        {
            SendRequest(ClientConfig.prodUrl + txtProdId.Text);
        }

        private void CmdJsonExport_Click(object sender, EventArgs e)
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
