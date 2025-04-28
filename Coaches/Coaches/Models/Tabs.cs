using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Tabs
{
    public int TabId { get; set; }

    public int TabOrder { get; set; }

    public int? PortalId { get; set; }

    public string TabName { get; set; } = null!;

    public bool? IsVisible { get; set; }

    public int? ParentId { get; set; }

    public string? IconFile { get; set; }

    public bool DisableLink { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? KeyWords { get; set; }

    public bool IsDeleted { get; set; }

    public string? Url { get; set; }

    public string? SkinSrc { get; set; }

    public string? ContainerSrc { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? RefreshInterval { get; set; }

    public string? PageHeadText { get; set; }

    public bool IsSecure { get; set; }

    public bool PermanentRedirect { get; set; }

    public double SiteMapPriority { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string? IconFileLarge { get; set; }

    public string? CultureCode { get; set; }

    public int? ContentItemId { get; set; }

    public Guid UniqueId { get; set; }

    public Guid VersionGuid { get; set; }

    public Guid? DefaultLanguageGuid { get; set; }

    public Guid LocalizedVersionGuid { get; set; }

    public int Level { get; set; }

    public string TabPath { get; set; } = null!;

    public bool HasBeenPublished { get; set; }

    public bool IsSystem { get; set; }

    public virtual ContentItems? ContentItem { get; set; }

    public virtual ICollection<Tabs> InverseParent { get; } = new List<Tabs>();

    public virtual Tabs? Parent { get; set; }

    public virtual Portals? Portal { get; set; }

    public virtual ICollection<TabModules> TabModules { get; } = new List<TabModules>();

    public virtual ICollection<TabPermission> TabPermission { get; } = new List<TabPermission>();

    public virtual ICollection<TabSettings> TabSettings { get; } = new List<TabSettings>();

    public virtual ICollection<TabUrls> TabUrls { get; } = new List<TabUrls>();

    public virtual ICollection<TabVersions> TabVersions { get; } = new List<TabVersions>();
}
