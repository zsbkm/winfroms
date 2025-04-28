using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class ContentWorkflowSources
{
    public int SourceId { get; set; }

    public int WorkflowId { get; set; }

    public string SourceName { get; set; } = null!;

    public string SourceType { get; set; } = null!;

    public virtual ContentWorkflows Workflow { get; set; } = null!;
}
