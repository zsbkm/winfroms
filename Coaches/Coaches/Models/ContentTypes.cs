using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class ContentTypes
{
    public int ContentTypeId { get; set; }

    public string ContentType { get; set; } = null!;

    public virtual ICollection<ContentItems> ContentItems { get; } = new List<ContentItems>();

    public virtual ICollection<ContentWorkflowActions> ContentWorkflowActions { get; } = new List<ContentWorkflowActions>();
}
