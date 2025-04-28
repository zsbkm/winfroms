using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccStoreSettings
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public virtual ICollection<HccStoreSettingsTranslations> HccStoreSettingsTranslations { get; } = new List<HccStoreSettingsTranslations>();

    public virtual HccStores Store { get; set; } = null!;
}
