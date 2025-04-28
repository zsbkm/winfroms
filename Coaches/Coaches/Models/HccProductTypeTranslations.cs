using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccProductTypeTranslations
{
    public long ProductTypeTranslationId { get; set; }

    public Guid ProductTypeId { get; set; }

    public string Culture { get; set; } = null!;

    public string? ProductTypeName { get; set; }

    public virtual HccProductType ProductType { get; set; } = null!;
}
