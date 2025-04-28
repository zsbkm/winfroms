using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccHtmlTemplateTranslations
{
    public long HtmlTemplateTranslationId { get; set; }

    public long HtmlTemplateId { get; set; }

    public string Culture { get; set; } = null!;

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string? RepeatingSection { get; set; }

    public virtual HccHtmlTemplates HtmlTemplate { get; set; } = null!;
}
