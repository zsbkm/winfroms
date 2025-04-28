using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class UserRelationshipPreferences
{
    public int PreferenceId { get; set; }

    public int UserId { get; set; }

    public int RelationshipId { get; set; }

    public int DefaultResponse { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public virtual Relationships Relationship { get; set; } = null!;

    public virtual Users User { get; set; } = null!;
}
