using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class ContentWorkflowStates
{
    public int StateId { get; set; }

    public int WorkflowId { get; set; }

    public string StateName { get; set; } = null!;

    public int Order { get; set; }

    public bool? IsActive { get; set; }

    public bool SendEmail { get; set; }

    public bool SendMessage { get; set; }

    public bool IsDisposalState { get; set; }

    public string OnCompleteMessageSubject { get; set; } = null!;

    public string OnCompleteMessageBody { get; set; } = null!;

    public string OnDiscardMessageSubject { get; set; } = null!;

    public string OnDiscardMessageBody { get; set; } = null!;

    public bool IsSystem { get; set; }

    public bool? SendNotification { get; set; }

    public bool? SendNotificationToAdministrators { get; set; }

    public virtual ICollection<ContentItems> ContentItems { get; } = new List<ContentItems>();

    public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; } = new List<ContentWorkflowStatePermission>();

    public virtual ContentWorkflows Workflow { get; set; } = null!;
}
