using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class PersonaBarMenu
{
    public int MenuId { get; set; }

    public string Identifier { get; set; } = null!;

    public string ModuleName { get; set; } = null!;

    public string? FolderName { get; set; }

    public string? Controller { get; set; }

    public string ResourceKey { get; set; } = null!;

    public string Path { get; set; } = null!;

    public string? Link { get; set; }

    public string? CssClass { get; set; }

    public int? ParentId { get; set; }

    public int Order { get; set; }

    public bool AllowHost { get; set; }

    public bool Enabled { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string? IconFile { get; set; }

    public virtual ICollection<PersonaBarMenu> InverseParent { get; } = new List<PersonaBarMenu>();

    public virtual PersonaBarMenu? Parent { get; set; }

    public virtual ICollection<PersonaBarExtensions> PersonaBarExtensions { get; } = new List<PersonaBarExtensions>();

    public virtual PersonaBarMenuDefaultPermissions? PersonaBarMenuDefaultPermissions { get; set; }

    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; } = new List<PersonaBarMenuPermission>();

    public virtual ICollection<PersonaBarPermission> PersonaBarPermission { get; } = new List<PersonaBarPermission>();
}
