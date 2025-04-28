using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class PackageTypes
{
    public string PackageType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int SecurityAccessLevel { get; set; }

    public string? EditorControlSrc { get; set; }

    public bool SupportsSideBySideInstallation { get; set; }

    public virtual ICollection<Packages> Packages { get; } = new List<Packages>();
}
