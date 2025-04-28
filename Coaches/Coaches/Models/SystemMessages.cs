using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class SystemMessages
{
    public int MessageId { get; set; }

    public int? PortalId { get; set; }

    public string MessageName { get; set; } = null!;

    public string MessageValue { get; set; } = null!;

    public virtual Portals? Portal { get; set; }
}
