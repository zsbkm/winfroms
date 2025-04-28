using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class DesktopModules
{
    public int DesktopModuleId { get; set; }

    public string FriendlyName { get; set; } = null!;

    public string? Description { get; set; }

    public string Version { get; set; } = null!;

    public bool IsPremium { get; set; }

    public bool IsAdmin { get; set; }

    public string? BusinessControllerClass { get; set; }

    public string FolderName { get; set; } = null!;

    public string ModuleName { get; set; } = null!;

    public int SupportedFeatures { get; set; }

    public string? CompatibleVersions { get; set; }

    public string? Dependencies { get; set; }

    public string? Permissions { get; set; }

    public int PackageId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public int ContentItemId { get; set; }

    public int Shareable { get; set; }

    public string? AdminPage { get; set; }

    public string? HostPage { get; set; }

    public virtual ICollection<CoreMessagingNotificationTypes> CoreMessagingNotificationTypes { get; } = new List<CoreMessagingNotificationTypes>();

    public virtual ICollection<ModuleDefinitions> ModuleDefinitions { get; } = new List<ModuleDefinitions>();

    public virtual Packages Package { get; set; } = null!;

    public virtual ICollection<PortalDesktopModules> PortalDesktopModules { get; } = new List<PortalDesktopModules>();
}
