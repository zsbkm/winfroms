using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccProductPropertyChoice
{
    public long Id { get; set; }

    public long PropertyId { get; set; }

    public string ChoiceName { get; set; } = null!;

    public int SortOrder { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public virtual ICollection<HccProductPropertyChoiceTranslations> HccProductPropertyChoiceTranslations { get; } = new List<HccProductPropertyChoiceTranslations>();

    public virtual HccProductProperty Property { get; set; } = null!;
}
