using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class VwMasterPortals
{
    public int PortalId { get; set; }

    public int? PortalGroupId { get; set; }

    public int MasterPortalId { get; set; }
}
