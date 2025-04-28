using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccProductOptionTranslations
{
    public long ProductOptionTranslationId { get; set; }

    public Guid ProductOptionId { get; set; }

    public string Culture { get; set; } = null!;

    public string? Name { get; set; }

    public string? TextSettings { get; set; }

    public virtual HccProductOptions ProductOption { get; set; } = null!;
}
