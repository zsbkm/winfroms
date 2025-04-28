using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Languages
{
    public int LanguageId { get; set; }

    public string CultureCode { get; set; } = null!;

    public string CultureName { get; set; } = null!;

    public string? FallbackCulture { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public bool? IsEnabled { get; set; }

    public virtual ICollection<PortalLanguages> PortalLanguages { get; } = new List<PortalLanguages>();
}
