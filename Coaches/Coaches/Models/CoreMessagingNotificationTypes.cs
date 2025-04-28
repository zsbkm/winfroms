using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class CoreMessagingNotificationTypes
{
    public int NotificationTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? Ttl { get; set; }

    public int? DesktopModuleId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsTask { get; set; }

    public virtual ICollection<CoreMessagingMessages> CoreMessagingMessages { get; } = new List<CoreMessagingMessages>();

    public virtual ICollection<CoreMessagingNotificationTypeActions> CoreMessagingNotificationTypeActions { get; } = new List<CoreMessagingNotificationTypeActions>();

    public virtual DesktopModules? DesktopModule { get; set; }
}
