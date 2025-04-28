using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccProduct
{
    public long Id { get; set; }

    public Guid Bvin { get; set; }

    public string Sku { get; set; } = null!;

    public Guid? ProductTypeId { get; set; }

    public decimal ListPrice { get; set; }

    public decimal SitePrice { get; set; }

    public decimal SiteCost { get; set; }

    public int TaxExempt { get; set; }

    public string TaxClass { get; set; } = null!;

    public int NonShipping { get; set; }

    public int ShipSeparately { get; set; }

    public int ShippingMode { get; set; }

    public decimal ShippingWeight { get; set; }

    public decimal ShippingLength { get; set; }

    public decimal ShippingWidth { get; set; }

    public decimal ShippingHeight { get; set; }

    public int Status { get; set; }

    public string ImageFileSmall { get; set; } = null!;

    public string ImageFileMedium { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public int MinimumQty { get; set; }

    public Guid? ManufacturerId { get; set; }

    public Guid? VendorId { get; set; }

    public int GiftWrapAllowed { get; set; }

    public decimal ExtraShipFee { get; set; }

    public DateTime LastUpdated { get; set; }

    public string TemplateName { get; set; } = null!;

    public string PreContentColumnId { get; set; } = null!;

    public string PostContentColumnId { get; set; } = null!;

    public string RewriteUrl { get; set; } = null!;

    public string CustomProperties { get; set; } = null!;

    public decimal GiftWrapPrice { get; set; }

    public long StoreId { get; set; }

    public bool Featured { get; set; }

    public bool? AllowReviews { get; set; }

    public int OutOfStockMode { get; set; }

    public bool? IsAvailableForSale { get; set; }

    public bool IsUserPrice { get; set; }

    public bool HideQty { get; set; }

    public bool? IsSearchable { get; set; }

    public bool IsBundle { get; set; }

    public bool IsGiftCard { get; set; }

    public bool IsRecurring { get; set; }

    public int? RecurringInterval { get; set; }

    public int? RecurringIntervalType { get; set; }

    public int ShippingCharge { get; set; }

    public bool AllowUpcharge { get; set; }

    public decimal UpchargeAmount { get; set; }

    public string? UpchargeUnit { get; set; }

    public virtual ICollection<HccBundledProducts> HccBundledProducts { get; } = new List<HccBundledProducts>();

    public virtual ICollection<HccCatalogRoles> HccCatalogRoles { get; } = new List<HccCatalogRoles>();

    public virtual ICollection<HccProductFileXproduct> HccProductFileXproduct { get; } = new List<HccProductFileXproduct>();

    public virtual ICollection<HccProductImage> HccProductImage { get; } = new List<HccProductImage>();

    public virtual ICollection<HccProductInventory> HccProductInventory { get; } = new List<HccProductInventory>();

    public virtual ICollection<HccProductPropertyValue> HccProductPropertyValue { get; } = new List<HccProductPropertyValue>();

    public virtual ICollection<HccProductRelationships> HccProductRelationships { get; } = new List<HccProductRelationships>();

    public virtual ICollection<HccProductReview> HccProductReview { get; } = new List<HccProductReview>();

    public virtual ICollection<HccProductTranslations> HccProductTranslations { get; } = new List<HccProductTranslations>();

    public virtual ICollection<HccProductVolumeDiscounts> HccProductVolumeDiscounts { get; } = new List<HccProductVolumeDiscounts>();

    public virtual ICollection<HccProductXcategory> HccProductXcategory { get; } = new List<HccProductXcategory>();

    public virtual ICollection<HccProductXoption> HccProductXoption { get; } = new List<HccProductXoption>();

    public virtual ICollection<HccVariants> HccVariants { get; } = new List<HccVariants>();

    public virtual ICollection<HccWishListItems> HccWishListItems { get; } = new List<HccWishListItems>();

    public virtual HccManufacturer? Manufacturer { get; set; }

    public virtual HccProductType? ProductType { get; set; }

    public virtual HccVendor? Vendor { get; set; }
}
