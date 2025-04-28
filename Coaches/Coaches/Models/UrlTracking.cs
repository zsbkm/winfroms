using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class UrlTracking
{
    public int UrlTrackingId { get; set; }

    public int? PortalId { get; set; }

    public string Url { get; set; } = null!;

    public string UrlType { get; set; } = null!;

    public int Clicks { get; set; }

    public DateTime? LastClick { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool LogActivity { get; set; }

    public bool? TrackClicks { get; set; }

    public int? ModuleId { get; set; }

    public bool NewWindow { get; set; }

    public virtual Portals? Portal { get; set; }

    public virtual ICollection<UrlLog> UrlLog { get; } = new List<UrlLog>();
}
