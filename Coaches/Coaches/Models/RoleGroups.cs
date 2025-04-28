using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class RoleGroups
{
    public int RoleGroupId { get; set; }

    public int PortalId { get; set; }

    public string RoleGroupName { get; set; } = null!;

    public string? Description { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Portals Portal { get; set; } = null!;

    public virtual ICollection<Roles> Roles { get; } = new List<Roles>();
}
