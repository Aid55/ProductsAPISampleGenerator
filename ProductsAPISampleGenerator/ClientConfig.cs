using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsAPISampleGenerator
{
    public static class ClientConfig
    {
        public static string baseUrl = "{Removed}";
        public static string billingUrl = baseUrl + "/billing/manufacturers";
        public static string manufacturersUrl = baseUrl + "/manufacturers";
        public static string mfrProdsUrl = baseUrl + "/manufacturers/";
        public static string prodUrl = baseUrl + "/products/";
        public static string apiKeyName = "ocp-apim-subscription-key";
        public static string apiUsKeyValue = "{Removed}";
        public static string apiUkKeyValue = "{Removed}";
    }
}
