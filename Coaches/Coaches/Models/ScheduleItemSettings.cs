using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class ScheduleItemSettings
{
    public int ScheduleId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;
}
