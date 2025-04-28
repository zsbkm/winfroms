using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Urls
{
    public int UrlId { get; set; }

    public int? PortalId { get; set; }

    public string Url { get; set; } = null!;

    public virtual Portals? Portal { get; set; }
}
