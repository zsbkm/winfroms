using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Files
{
    public int FileId { get; set; }

    public int? PortalId { get; set; }

    public string FileName { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public int Size { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string ContentType { get; set; } = null!;

    public int FolderId { get; set; }

    public byte[]? Content { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public Guid UniqueId { get; set; }

    public Guid VersionGuid { get; set; }

    public string? Sha1hash { get; set; }

    public DateTime LastModificationTime { get; set; }

    public string? Folder { get; set; }

    public string? Title { get; set; }

    public DateTime StartDate { get; set; }

    public bool EnablePublishPeriod { get; set; }

    public DateTime? EndDate { get; set; }

    public int PublishedVersion { get; set; }

    public int? ContentItemId { get; set; }

    public bool? HasBeenPublished { get; set; }

    public string? Description { get; set; }

    public virtual ContentItems? ContentItem { get; set; }

    public virtual ICollection<FileVersions> FileVersions { get; } = new List<FileVersions>();

    public virtual Folders FolderNavigation { get; set; } = null!;

    public virtual Portals? Portal { get; set; }
}
