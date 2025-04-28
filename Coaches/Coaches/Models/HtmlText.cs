using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HtmlText
{
    public int ModuleId { get; set; }

    public int ItemId { get; set; }

    public string? Content { get; set; }

    public int? Version { get; set; }

    public int? StateId { get; set; }

    public bool? IsPublished { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string? Summary { get; set; }

    public virtual ICollection<HtmlTextLog> HtmlTextLog { get; } = new List<HtmlTextLog>();

    public virtual ICollection<HtmlTextUsers> HtmlTextUsers { get; } = new List<HtmlTextUsers>();

    public virtual Modules Module { get; set; } = null!;

    public virtual WorkflowStates? State { get; set; }
}
