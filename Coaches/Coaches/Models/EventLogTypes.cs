using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class EventLogTypes
{
    public string LogTypeKey { get; set; } = null!;

    public string LogTypeFriendlyName { get; set; } = null!;

    public string LogTypeDescription { get; set; } = null!;

    public string LogTypeOwner { get; set; } = null!;

    public string LogTypeCssclass { get; set; } = null!;

    public virtual ICollection<EventLog> EventLog { get; } = new List<EventLog>();

    public virtual ICollection<EventLogConfig> EventLogConfig { get; } = new List<EventLogConfig>();
}
