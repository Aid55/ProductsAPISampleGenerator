using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProductsAPISampleGenerator
{

    public partial class MainForm : Form
    {

        string strResponse = string.Empty;

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

    }
}
