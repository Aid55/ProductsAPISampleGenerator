using System;
using System.Collections.Generic;
using System.Text;

namespace productsAPIClient
{
    public static class ClientConfig
    {
        public static string baseUrl = "https://api.aq-fes.com/products-api/";
        public static string billingUrl = baseUrl + "/billing/manufacturers";
        public static string mfrProdsUrl = baseUrl + "/manufacturers/";
        public static string prodUrl = baseUrl + "/products/";
        public static string apiKeyName = "ocp-apim-subscription-key";
        public static string apiKeyValue = "931203a189534d8e849b0666704cf1ad";
    }
}
