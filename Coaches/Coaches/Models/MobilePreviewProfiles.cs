using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class MobilePreviewProfiles
{
    public int Id { get; set; }

    public int PortalId { get; set; }

    public string Name { get; set; } = null!;

    public int Width { get; set; }

    public int Height { get; set; }

    public string UserAgent { get; set; } = null!;

    public int SortOrder { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public virtual Portals Portal { get; set; } = null!;
}
