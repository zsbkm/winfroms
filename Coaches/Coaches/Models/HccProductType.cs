using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccProductType
{
    public Guid Bvin { get; set; }

    public bool IsPermanent { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public string TemplateName { get; set; } = null!;

    public virtual ICollection<HccCatalogRoles> HccCatalogRoles { get; } = new List<HccCatalogRoles>();

    public virtual HccMembershipProductType? HccMembershipProductType { get; set; }

    public virtual ICollection<HccProduct> HccProduct { get; } = new List<HccProduct>();

    public virtual ICollection<HccProductTypeTranslations> HccProductTypeTranslations { get; } = new List<HccProductTypeTranslations>();

    public virtual ICollection<HccProductTypeXproductProperty> HccProductTypeXproductProperty { get; } = new List<HccProductTypeXproductProperty>();
}
