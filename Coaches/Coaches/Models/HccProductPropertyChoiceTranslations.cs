using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccProductPropertyChoiceTranslations
{
    public long ProductPropertyChoiceTranslationId { get; set; }

    public long ProductPropertyChoiceId { get; set; }

    public string Culture { get; set; } = null!;

    public string? DisplayName { get; set; }

    public virtual HccProductPropertyChoice ProductPropertyChoice { get; set; } = null!;
}
