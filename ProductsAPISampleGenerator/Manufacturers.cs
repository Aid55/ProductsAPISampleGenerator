using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsAPISampleGenerator
{

    public partial class Manufacturers
    {
        public ManufacturersDatum[] Data { get; set; }
    }

    public partial class ManufacturersDatum
    {
        public Guid? MfrId { get; set; }
        public long MfrNumber { get; set; }
        public string MfrName { get; set; }
        public string MfrShortName { get; set; }
        public string MfrUrl { get; set; }
        public Uri? LogoUrl { get; set; }
        public object[] DiscountCategories { get; set; }
    }

    public partial class DiscountCategory
    {
        public Guid? DiscountCategoryId { get; set; }
        public string Name { get; set; }
    }
}