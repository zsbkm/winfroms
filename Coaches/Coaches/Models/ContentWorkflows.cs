using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class ContentWorkflows
{
    public int WorkflowId { get; set; }

    public int? PortalId { get; set; }

    public string WorkflowName { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    public bool? StartAfterCreating { get; set; }

    public bool? StartAfterEditing { get; set; }

    public bool DispositionEnabled { get; set; }

    public bool IsSystem { get; set; }

    public string WorkflowKey { get; set; } = null!;

    public virtual ICollection<ContentWorkflowLogs> ContentWorkflowLogs { get; } = new List<ContentWorkflowLogs>();

    public virtual ICollection<ContentWorkflowSources> ContentWorkflowSources { get; } = new List<ContentWorkflowSources>();

    public virtual ICollection<ContentWorkflowStates> ContentWorkflowStates { get; } = new List<ContentWorkflowStates>();

    public virtual ICollection<Folders> Folders { get; } = new List<Folders>();
}
