using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

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
            SendRequest(ClientConfig.billingUrl);
            DebugOutput(strResponse);
        }

        private void CmdMfrProducts_Click(object sender, EventArgs e)
        {
            SendRequest(ClientConfig.mfrProdsUrl + txtMfrId.Text + "/products");
            DebugOutput(strResponse);
        }

        private void CmdProduct_Click(object sender, EventArgs e)
        {
            SendRequest(ClientConfig.prodUrl + txtProdId.Text);
            DebugOutput(strResponse);
        }

        private void CmdGetProductList_Click(object sender, EventArgs e)
        {
            string[] prodIds = txtProdIdList.Text.Split(Environment.NewLine);
            string jsonString = "{\"data\":[";
            foreach (string prodId in prodIds)
            {
                SendRequest(ClientConfig.prodUrl + prodId);
                Object jsonObjectData = DeserializeJson(strResponse);
                string newString = SerializeJson(jsonObjectData);
                jsonString += newString;
                jsonString += ",";
            }
            jsonString = jsonString.Remove(jsonString.Length - 1, 1);
            jsonString += "]}";
            strResponse = string.Empty;
            strResponse = jsonString;
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


    }
}
