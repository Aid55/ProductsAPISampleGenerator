using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsAPISampleGenerator
{
    class Product
    {
        public ProductDatum Data { get; set; }
    }

    public partial class ProductDatum
    {
        public Guid? ProductId { get; set; }
        public Guid? MfrId { get; set; }
        public ProductModels Models { get; set; }
        public ProductSpecifications Specifications { get; set; }
        public ProductProductCategory ProductCategory { get; set; }
        public object[] CategoryValues { get; set; }
        public bool IsConfigurable { get; set; }
        public ProductDocument[] Pictures { get; set; }
        public ProductDocument[] Documents { get; set; }
        public object[] Drawings { get; set; }
        public ProductProductDimension ProductDimension { get; set; }
        public string FreightClass { get; set; }
        public string ShipFromZip { get; set; }
        public ProductPackingData PackingData { get; set; }
        public ProductPricing Pricing { get; set; }
        public Gtin? Gtin { get; set; }
        public string Prop65 { get; set; }
        public object[] Certifications { get; set; }
        public string BrandName { get; set; }
        public Guid? BrandId { get; set; }
    }

    public partial class ProductDocument
    {
        public string Name { get; set; }
        public Uri? Url { get; set; }
        public string MimeType { get; set; }
        public string MediaType { get; set; }
    }

    public partial class ProductGtin
    {
        public object[] Each { get; set; }
        public object[] InnerPacks { get; set; }
        public object[] OuterPacks { get; set; }
    }

    public partial class ProductModels
    {
        public string MfrModel { get; set; }
        public string StockModel { get; set; }
        public object[] ObsoleteModels { get; set; }
    }

    public partial class ProductPackingData
    {
        public long UnitsPerCase { get; set; }
        public string SellingUnit { get; set; }
        public string CaseName { get; set; }
        public string PackedBy { get; set; }
        public string PriceBy { get; set; }
    }

    public partial class ProductPricing
    {
        public long ListPrice { get; set; }
        public bool IsCallPrice { get; set; }
        public long Markup { get; set; }
        public long SellPrice { get; set; }
        public string ListPriceDate { get; set; }
        public long FlyerNetPrice { get; set; }
        public object[] QtyPricing { get; set; }
        public object[] CasePricing { get; set; }
    }

    public partial class ProductProductCategory
    {
        public string Name { get; set; }
        public Guid? CategoryId { get; set; }
    }

    public partial class ProductProductDimension
    {
        public long ProductHeight { get; set; }
        public long ProductWidth { get; set; }
        public long ProductDepth { get; set; }
        public long ShippingCube { get; set; }
        public long ShippingWeight { get; set; }
    }

    public partial class ProductSpecifications
    {
        public string AqSpecification { get; set; }
        public string ShortMarketingSpecification { get; set; }
        public string LongMarketingSpecification { get; set; }
    }
}
