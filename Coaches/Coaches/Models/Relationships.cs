using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Relationships
{
    public int RelationshipId { get; set; }

    public int RelationshipTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? PortalId { get; set; }

    public int? UserId { get; set; }

    public int DefaultResponse { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public virtual Portals? Portal { get; set; }

    public virtual RelationshipTypes RelationshipType { get; set; } = null!;

    public virtual Users? User { get; set; }

    public virtual ICollection<UserRelationshipPreferences> UserRelationshipPreferences { get; } = new List<UserRelationshipPreferences>();

    public virtual ICollection<UserRelationships> UserRelationships { get; } = new List<UserRelationships>();
}
