using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccProductProperty
{
    public long Id { get; set; }

    public string PropertyName { get; set; } = null!;

    public int DisplayOnSite { get; set; }

    public int DisplayToDropShipper { get; set; }

    public int TypeCode { get; set; }

    public string DefaultValue { get; set; } = null!;

    public string CultureCode { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public bool DisplayOnSearch { get; set; }

    public bool IsLocalizable { get; set; }

    public virtual ICollection<HccProductPropertyChoice> HccProductPropertyChoice { get; } = new List<HccProductPropertyChoice>();

    public virtual ICollection<HccProductPropertyTranslations> HccProductPropertyTranslations { get; } = new List<HccProductPropertyTranslations>();

    public virtual ICollection<HccProductPropertyValue> HccProductPropertyValue { get; } = new List<HccProductPropertyValue>();

    public virtual ICollection<HccProductTypeXproductProperty> HccProductTypeXproductProperty { get; } = new List<HccProductTypeXproductProperty>();
}
