using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Skins
{
    public int SkinId { get; set; }

    public int SkinPackageId { get; set; }

    public string SkinSrc { get; set; } = null!;

    public virtual SkinPackages SkinPackage { get; set; } = null!;
}
