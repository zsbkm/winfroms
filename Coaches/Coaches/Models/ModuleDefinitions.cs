using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class ModuleDefinitions
{
    public int ModuleDefId { get; set; }

    public string FriendlyName { get; set; } = null!;

    public int DesktopModuleId { get; set; }

    public int DefaultCacheTime { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string DefinitionName { get; set; } = null!;

    public virtual DesktopModules DesktopModule { get; set; } = null!;

    public virtual ICollection<ModuleControls> ModuleControls { get; } = new List<ModuleControls>();

    public virtual ICollection<Modules> Modules { get; } = new List<Modules>();
}
