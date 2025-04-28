using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Roles
{
    public int RoleId { get; set; }

    public int? PortalId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? ServiceFee { get; set; }

    public string? BillingFrequency { get; set; }

    public int? TrialPeriod { get; set; }

    public string? TrialFrequency { get; set; }

    public int? BillingPeriod { get; set; }

    public decimal? TrialFee { get; set; }

    public bool IsPublic { get; set; }

    public bool AutoAssignment { get; set; }

    public int? RoleGroupId { get; set; }

    public string? Rsvpcode { get; set; }

    public string? IconFile { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public int Status { get; set; }

    public int SecurityMode { get; set; }

    public bool IsSystemRole { get; set; }

    public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; } = new List<DesktopModulePermission>();

    public virtual ICollection<FolderPermission> FolderPermission { get; } = new List<FolderPermission>();

    public virtual ICollection<ModulePermission> ModulePermission { get; } = new List<ModulePermission>();

    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; } = new List<PersonaBarMenuPermission>();

    public virtual Portals? Portal { get; set; }

    public virtual ICollection<PortalPermission> PortalPermission { get; } = new List<PortalPermission>();

    public virtual RoleGroups? RoleGroup { get; set; }

    public virtual ICollection<TabPermission> TabPermission { get; } = new List<TabPermission>();

    public virtual ICollection<UserRoles> UserRoles { get; } = new List<UserRoles>();
}
