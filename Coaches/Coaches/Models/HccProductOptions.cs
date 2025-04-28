using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccProductOptions
{
    public Guid Bvin { get; set; }

    public long StoreId { get; set; }

    public int OptionType { get; set; }

    public bool NameIsHidden { get; set; }

    public bool IsVariant { get; set; }

    public bool IsShared { get; set; }

    public string Settings { get; set; } = null!;

    public bool IsColorSwatch { get; set; }

    public virtual ICollection<HccProductOptionTranslations> HccProductOptionTranslations { get; } = new List<HccProductOptionTranslations>();

    public virtual ICollection<HccProductOptionsItems> HccProductOptionsItems { get; } = new List<HccProductOptionsItems>();

    public virtual ICollection<HccProductXoption> HccProductXoption { get; } = new List<HccProductXoption>();
}
