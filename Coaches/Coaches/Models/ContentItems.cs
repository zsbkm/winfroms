using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class ContentItems
{
    public int ContentItemId { get; set; }

    public string? Content { get; set; }

    public int ContentTypeId { get; set; }

    public int TabId { get; set; }

    public int ModuleId { get; set; }

    public string? ContentKey { get; set; }

    public bool Indexed { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public int? StateId { get; set; }

    public virtual ICollection<ContentItemsMetaData> ContentItemsMetaData { get; } = new List<ContentItemsMetaData>();

    public virtual ICollection<ContentItemsTags> ContentItemsTags { get; } = new List<ContentItemsTags>();

    public virtual ContentTypes ContentType { get; set; } = null!;

    public virtual ICollection<ContentWorkflowLogs> ContentWorkflowLogs { get; } = new List<ContentWorkflowLogs>();

    public virtual ICollection<Files> Files { get; } = new List<Files>();

    public virtual ICollection<Modules> Modules { get; } = new List<Modules>();

    public virtual ContentWorkflowStates? State { get; set; }

    public virtual ICollection<Tabs> Tabs { get; } = new List<Tabs>();
}
