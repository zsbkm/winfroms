using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class CoreMessagingSubscriptionTypes
{
    public int SubscriptionTypeId { get; set; }

    public string SubscriptionName { get; set; } = null!;

    public string FriendlyName { get; set; } = null!;

    public int? DesktopModuleId { get; set; }

    public virtual ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; } = new List<CoreMessagingSubscriptions>();
}
