using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsAPISampleGenerator
{
    class ProductsByMfr
    {
        public ProductsByMfrDatum[] Data { get; set; }
    }

    public partial class ProductsByMfrDatum
    {
        public Guid? ProductId { get; set; }
        public Guid? MfrId { get; set; }
        public Models Models { get; set; }
        public Specifications Specifications { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public object[] CategoryValues { get; set; }
        public bool IsConfigurable { get; set; }
        public Document[] Pictures { get; set; }
        public Document[] Documents { get; set; }
        public object[] Drawings { get; set; }
        public ProductDimension ProductDimension { get; set; }
        public string FreightClass { get; set; }
        public string ShipFromZip { get; set; }
        public PackingData PackingData { get; set; }
        public Pricing Pricing { get; set; }
        public Gtin? Gtin { get; set; }
        public string Prop65 { get; set; }
        public object[] Certifications { get; set; }
        public string BrandName { get; set; }
        public Guid? BrandId { get; set; }
    }

    public partial class Document
    {
        public string Name { get; set; }
        public Uri? Url { get; set; }
        public string MimeType { get; set; }
        public string MediaType { get; set; }
    }

    public partial class Gtin
    {
        public object[] Each { get; set; }
        public object[] InnerPacks { get; set; }
        public object[] OuterPacks { get; set; }
    }

    public partial class Models
    {
        public string MfrModel { get; set; }
        public string StockModel { get; set; }
        public object[] ObsoleteModels { get; set; }
    }

    public partial class PackingData
    {
        public long UnitsPerCase { get; set; }
        public string SellingUnit { get; set; }
        public string CaseName { get; set; }
        public string PackedBy { get; set; }
        public string PriceBy { get; set; }
    }

    public partial class Pricing
    {
        public long NetPrice { get; set; }
        public long ListPrice { get; set; }
        public bool IsCallPrice { get; set; }
        public long Markup { get; set; }
        public long SellPrice { get; set; }
        public string ListPriceDate { get; set; }
        public long FlyerNetPrice { get; set; }
        public object[] QtyPricing { get; set; }
        public object[] CasePricing { get; set; }
    }

    public partial class ProductCategory
    {
        public string Name { get; set; }
        public Guid? CategoryId { get; set; }
    }

    public partial class ProductDimension
    {
        public long ProductHeight { get; set; }
        public long ProductWidth { get; set; }
        public long ProductDepth { get; set; }
        public long ShippingCube { get; set; }
        public long ShippingWeight { get; set; }
    }

    public partial class Specifications
    {
        public string AqSpecification { get; set; }
        public string ShortMarketingSpecification { get; set; }
        public string LongMarketingSpecification { get; set; }
    }
}

