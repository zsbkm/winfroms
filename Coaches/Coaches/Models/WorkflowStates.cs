using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class WorkflowStates
{
    public int StateId { get; set; }

    public int WorkflowId { get; set; }

    public string StateName { get; set; } = null!;

    public int Order { get; set; }

    public bool IsActive { get; set; }

    public bool Notify { get; set; }

    public virtual ICollection<HtmlText> HtmlText { get; } = new List<HtmlText>();

    public virtual ICollection<HtmlTextLog> HtmlTextLog { get; } = new List<HtmlTextLog>();

    public virtual Workflow Workflow { get; set; } = null!;
}
