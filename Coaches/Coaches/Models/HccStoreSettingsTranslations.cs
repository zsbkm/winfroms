using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccStoreSettingsTranslations
{
    public long StoreSettingsTranslationId { get; set; }

    public long StoreSettingsId { get; set; }

    public string Culture { get; set; } = null!;

    public string? LocalizedSettingValue { get; set; }

    public virtual HccStoreSettings StoreSettings { get; set; } = null!;
}
