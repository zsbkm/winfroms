using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Modules
{
    public int ModuleId { get; set; }

    public int ModuleDefId { get; set; }

    public bool AllTabs { get; set; }

    public bool IsDeleted { get; set; }

    public bool? InheritViewPermissions { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? PortalId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? LastContentModifiedOnDate { get; set; }

    public int? ContentItemId { get; set; }

    public bool? IsShareable { get; set; }

    public bool? IsShareableViewOnly { get; set; }

    public virtual ContentItems? ContentItem { get; set; }

    public virtual ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; } = new List<CoreMessagingSubscriptions>();

    public virtual ICollection<HtmlText> HtmlText { get; } = new List<HtmlText>();

    public virtual ModuleDefinitions ModuleDef { get; set; } = null!;

    public virtual ICollection<ModulePermission> ModulePermission { get; } = new List<ModulePermission>();

    public virtual ICollection<ModuleSettings> ModuleSettings { get; } = new List<ModuleSettings>();

    public virtual ICollection<RevindexBlockContent> RevindexBlockContent { get; } = new List<RevindexBlockContent>();

    public virtual ICollection<TabModules> TabModules { get; } = new List<TabModules>();
}
