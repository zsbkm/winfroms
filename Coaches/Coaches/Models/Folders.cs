using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Folders
{
    public int FolderId { get; set; }

    public int? PortalId { get; set; }

    public string FolderPath { get; set; } = null!;

    public int StorageLocation { get; set; }

    public bool IsProtected { get; set; }

    public bool IsCached { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public Guid UniqueId { get; set; }

    public Guid VersionGuid { get; set; }

    public int FolderMappingId { get; set; }

    public int? ParentId { get; set; }

    public bool IsVersioned { get; set; }

    public int? WorkflowId { get; set; }

    public string? MappedPath { get; set; }

    public virtual ICollection<Files> Files { get; } = new List<Files>();

    public virtual FolderMappings FolderMapping { get; set; } = null!;

    public virtual ICollection<FolderPermission> FolderPermission { get; } = new List<FolderPermission>();

    public virtual Portals? Portal { get; set; }

    public virtual ContentWorkflows? Workflow { get; set; }
}
