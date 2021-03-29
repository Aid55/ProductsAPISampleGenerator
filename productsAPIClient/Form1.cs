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

        private void cmdSend_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient(); 
            rClient.endPoint = txtUrl.Text;
            txtResponse.Text = string.Empty;
            debugOutput("Rest client created");
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest(txtAqKeyName.Text.ToString(),txtAqKeyValue.Text.ToString());
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

        private void debugOutput(string strDebugText)
        {
            System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
            txtResponse.Text += strDebugText + Environment.NewLine;
        }

        private void cmdMfrBillingInfo_Click(object sender, EventArgs e)
        {
            txtUrl.Text = "https://api.aq-fes.com/products-api/billing/manufacturers";
        }

        private void cmdMfrProducts_Click(object sender, EventArgs e)
        {
            txtUrl.Text = "https://api.aq-fes.com/products-api/manufacturers/" + txtMfrId.Text + "/products";
        }

        private void cmdProduct_Click(object sender, EventArgs e)
        {
            txtUrl.Text = "https://api.aq-fes.com/products-api/products/" + txtProdId.Text;
        }
    }
}
