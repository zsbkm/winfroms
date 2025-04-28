using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Profile
{
    public int ProfileId { get; set; }

    public int UserId { get; set; }

    public int PortalId { get; set; }

    public string ProfileData { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public virtual Portals Portal { get; set; } = null!;

    public virtual Users User { get; set; } = null!;
}
