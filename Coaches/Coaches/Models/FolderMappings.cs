using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class FolderMappings
{
    public int FolderMappingId { get; set; }

    public int? PortalId { get; set; }

    public string MappingName { get; set; } = null!;

    public string FolderProviderType { get; set; } = null!;

    public int? Priority { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual ICollection<FolderMappingsSettings> FolderMappingsSettings { get; } = new List<FolderMappingsSettings>();

    public virtual ICollection<Folders> Folders { get; } = new List<Folders>();

    public virtual Portals? Portal { get; set; }
}
