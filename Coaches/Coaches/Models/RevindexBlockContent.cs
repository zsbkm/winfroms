using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class RevindexBlockContent
{
    public int ContentId { get; set; }

    public int ModuleId { get; set; }

    public string? Html { get; set; }

    public bool Published { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public int? CreatedByUserId { get; set; }

    public int? UpdatedByUserId { get; set; }

    public int? Version { get; set; }

    public virtual Modules Module { get; set; } = null!;
}
