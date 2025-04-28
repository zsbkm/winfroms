using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class ContentWorkflowLogs
{
    public int WorkflowLogId { get; set; }

    public string Action { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateTime Date { get; set; }

    public int User { get; set; }

    public int WorkflowId { get; set; }

    public int ContentItemId { get; set; }

    public int Type { get; set; }

    public virtual ContentItems ContentItem { get; set; } = null!;

    public virtual ContentWorkflows Workflow { get; set; } = null!;
}
