using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class MobileRedirectionRules
{
    public int Id { get; set; }

    public int RedirectionId { get; set; }

    public string Capability { get; set; } = null!;

    public string Expression { get; set; } = null!;

    public virtual MobileRedirections Redirection { get; set; } = null!;
}
