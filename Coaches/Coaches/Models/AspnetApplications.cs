using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class AspnetApplications
{
    public string ApplicationName { get; set; } = null!;

    public string LoweredApplicationName { get; set; } = null!;

    public Guid ApplicationId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<AspnetMembership> AspnetMembership { get; } = new List<AspnetMembership>();

    public virtual ICollection<AspnetUsers> AspnetUsers { get; } = new List<AspnetUsers>();
}
