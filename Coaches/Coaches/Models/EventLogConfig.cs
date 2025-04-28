using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class EventLogConfig
{
    public int Id { get; set; }

    public string? LogTypeKey { get; set; }

    public int? LogTypePortalId { get; set; }

    public bool LoggingIsActive { get; set; }

    public int KeepMostRecent { get; set; }

    public bool EmailNotificationIsActive { get; set; }

    public int? NotificationThreshold { get; set; }

    public int? NotificationThresholdTime { get; set; }

    public int? NotificationThresholdTimeType { get; set; }

    public string MailFromAddress { get; set; } = null!;

    public string MailToAddress { get; set; } = null!;

    public virtual ICollection<EventLog> EventLog { get; } = new List<EventLog>();

    public virtual EventLogTypes? LogTypeKeyNavigation { get; set; }
}
