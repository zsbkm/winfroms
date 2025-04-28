using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Permission
{
    public int PermissionId { get; set; }

    public string PermissionCode { get; set; } = null!;

    public int ModuleDefId { get; set; }

    public string PermissionKey { get; set; } = null!;

    public string PermissionName { get; set; } = null!;

    public int ViewOrder { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; } = new List<ContentWorkflowStatePermission>();

    public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; } = new List<DesktopModulePermission>();

    public virtual ICollection<FolderPermission> FolderPermission { get; } = new List<FolderPermission>();

    public virtual ICollection<ModulePermission> ModulePermission { get; } = new List<ModulePermission>();

    public virtual ICollection<PortalPermission> PortalPermission { get; } = new List<PortalPermission>();

    public virtual ICollection<TabPermission> TabPermission { get; } = new List<TabPermission>();
}
