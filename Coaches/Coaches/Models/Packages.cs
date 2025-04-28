using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Packages
{
    public int PackageId { get; set; }

    public int? PortalId { get; set; }

    public string Name { get; set; } = null!;

    public string FriendlyName { get; set; } = null!;

    public string? Description { get; set; }

    public string PackageType { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string? License { get; set; }

    public string? Manifest { get; set; }

    public string? Owner { get; set; }

    public string? Organization { get; set; }

    public string? Url { get; set; }

    public string? Email { get; set; }

    public string? ReleaseNotes { get; set; }

    public bool IsSystemPackage { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string? FolderName { get; set; }

    public string? IconFile { get; set; }

    public virtual ICollection<Assemblies> Assemblies { get; } = new List<Assemblies>();

    public virtual ICollection<Authentication> Authentication { get; } = new List<Authentication>();

    public virtual ICollection<DesktopModules> DesktopModules { get; } = new List<DesktopModules>();

    public virtual ICollection<JavaScriptLibraries> JavaScriptLibraries { get; } = new List<JavaScriptLibraries>();

    public virtual ICollection<LanguagePacks> LanguagePacks { get; } = new List<LanguagePacks>();

    public virtual ICollection<PackageDependencies> PackageDependencies { get; } = new List<PackageDependencies>();

    public virtual PackageTypes PackageTypeNavigation { get; set; } = null!;

    public virtual ICollection<SkinControls> SkinControls { get; } = new List<SkinControls>();

    public virtual ICollection<SkinPackages> SkinPackages { get; } = new List<SkinPackages>();
}
