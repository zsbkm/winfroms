using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Assemblies
{
    public int AssemblyId { get; set; }

    public int? PackageId { get; set; }

    public string AssemblyName { get; set; } = null!;

    public string Version { get; set; } = null!;

    public virtual Packages? Package { get; set; }
}
