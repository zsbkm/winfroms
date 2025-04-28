using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class SkinPackages
{
    public int SkinPackageId { get; set; }

    public int PackageId { get; set; }

    public int? PortalId { get; set; }

    public string SkinName { get; set; } = null!;

    public string SkinType { get; set; } = null!;

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Packages Package { get; set; } = null!;

    public virtual ICollection<Skins> Skins { get; } = new List<Skins>();
}
