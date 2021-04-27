using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsAPISampleGenerator
{
    class MfrBilling
    {
        public MfrBillingDatum[] Data { get; set; }
    }

    public partial class MfrBillingDatum
    {
        public Guid MfrId { get; set; }
        public string MfrName { get; set; }
        public long BillableProductsCount { get; set; }
    }
}
