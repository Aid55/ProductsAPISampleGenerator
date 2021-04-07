using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Text;

namespace productsAPIClient
{
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RestClient
    {
        public string EndPoint { get; set; }
        public HttpVerb HttpMethod { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public RestClient()
        {
            EndPoint = string.Empty;
            HttpMethod = HttpVerb.GET;
            
        }

        public string MakeRequest(string username, string password)
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(EndPoint);
            request.Headers.Set(username, password);
            request.Method = HttpMethod.ToString();
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                //process reponse
                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }//end of stream reader
                    }
                }//end of using responsestream
            }
            catch(Exception ex)
            {
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if(response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

            return strResponseValue;
        }
    }
}
