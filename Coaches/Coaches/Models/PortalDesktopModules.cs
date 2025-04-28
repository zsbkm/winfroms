using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class PortalDesktopModules
{
    public int PortalDesktopModuleId { get; set; }

    public int PortalId { get; set; }

    public int DesktopModuleId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual DesktopModules DesktopModule { get; set; } = null!;

    public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; } = new List<DesktopModulePermission>();

    public virtual Portals Portal { get; set; } = null!;
}
