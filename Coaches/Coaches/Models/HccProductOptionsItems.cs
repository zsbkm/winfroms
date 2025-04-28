using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccProductOptionsItems
{
    public Guid Bvin { get; set; }

    public long StoreId { get; set; }

    public Guid OptionBvin { get; set; }

    public decimal PriceAdjustment { get; set; }

    public decimal WeightAdjustment { get; set; }

    public bool IsLabel { get; set; }

    public int SortOrder { get; set; }

    public bool IsDefault { get; set; }

    public virtual ICollection<HccProductOptionItemTranslations> HccProductOptionItemTranslations { get; } = new List<HccProductOptionItemTranslations>();

    public virtual HccProductOptions OptionBvinNavigation { get; set; } = null!;
}
