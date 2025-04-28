using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class ContentWorkflowActions
{
    public int ActionId { get; set; }

    public int ContentTypeId { get; set; }

    public string ActionType { get; set; } = null!;

    public string ActionSource { get; set; } = null!;

    public virtual ContentTypes ContentType { get; set; } = null!;
}
