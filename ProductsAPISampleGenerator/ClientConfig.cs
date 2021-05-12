using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsAPISampleGenerator
{
    public static class ClientConfig
    {
        public static string baseUrl = "https://api.aq-fes.com/products-api/";
        public static string billingUrl = baseUrl + "/billing/manufacturers";
        public static string manufacturersUrl = baseUrl + "/manufacturers";
        public static string mfrProdsUrl = baseUrl + "/manufacturers/";
        public static string prodUrl = baseUrl + "/products/";
        public static string apiKeyName = "ocp-apim-subscription-key";
        public static string apiUsKeyValue = "aba714bbb861463391ac4275ecc69e3d";
        public static string apiUkKeyValue = "931203a189534d8e849b0666704cf1ad";
        //US = aba714bbb861463391ac4275ecc69e3d
        //UK = 931203a189534d8e849b0666704cf1ad
    }
}
