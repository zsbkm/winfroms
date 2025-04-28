using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class PersonaBarMenuDefaultPermissions
{
    public int Id { get; set; }

    public int MenuId { get; set; }

    public string RoleNames { get; set; } = null!;

    public virtual PersonaBarMenu Menu { get; set; } = null!;
}
