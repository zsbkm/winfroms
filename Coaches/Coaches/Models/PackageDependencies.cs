using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class PackageDependencies
{
    public int PackageDependencyId { get; set; }

    public int PackageId { get; set; }

    public string PackageName { get; set; } = null!;

    public string Version { get; set; } = null!;

    public virtual Packages Package { get; set; } = null!;
}
