using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace productsAPIClient
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendRequest(string url)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = url;
            txtResponse.Text = string.Empty;
            debugOutput("Rest client created");
            string strResponse = string.Empty;
            if (ClientConfig.apiKeyName == string.Empty || ClientConfig.apiKeyValue == string.Empty)
            {
                strResponse = rClient.makeRequest(txtAqKeyName.Text.ToString(), txtAqKeyValue.Text.ToString());
            }
            else
            {
                strResponse = rClient.makeRequest(ClientConfig.apiKeyName, ClientConfig.apiKeyValue);
            }
            deserializeJson(strResponse);
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
            saveFileDialog1.ShowDialog();
        }

    }
}
