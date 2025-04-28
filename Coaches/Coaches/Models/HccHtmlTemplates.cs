using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccHtmlTemplates
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public DateTime LastUpdatedUtc { get; set; }

    public string DisplayName { get; set; } = null!;

    public string FromEmail { get; set; } = null!;

    public int TemplateType { get; set; }

    public virtual ICollection<HccHtmlTemplateTranslations> HccHtmlTemplateTranslations { get; } = new List<HccHtmlTemplateTranslations>();
}
