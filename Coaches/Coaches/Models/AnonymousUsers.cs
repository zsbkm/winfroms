using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class AnonymousUsers
{
    public string UserId { get; set; } = null!;

    public int PortalId { get; set; }

    public int TabId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime LastActiveDate { get; set; }

    public virtual Portals Portal { get; set; } = null!;
}
