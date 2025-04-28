using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HelloWorldItems
{
    public int ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public string ItemDescription { get; set; } = null!;

    public int? AssignedUserId { get; set; }

    public int ModuleId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }
}
