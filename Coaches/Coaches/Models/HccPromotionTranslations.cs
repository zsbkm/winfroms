using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccPromotionTranslations
{
    public long PromotionTranslationId { get; set; }

    public long PromotionId { get; set; }

    public string Culture { get; set; } = null!;

    public string? CustomerDescription { get; set; }

    public virtual HccPromotions Promotion { get; set; } = null!;
}
