using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccProductOptionItemTranslations
{
    public long ProductOptionItemTranslationId { get; set; }

    public Guid ProductOptionItemId { get; set; }

    public string Culture { get; set; } = null!;

    public string? Name { get; set; }

    public virtual HccProductOptionsItems ProductOptionItem { get; set; } = null!;
}
