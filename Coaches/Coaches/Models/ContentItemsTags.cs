using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class ContentItemsTags
{
    public int ContentItemTagId { get; set; }

    public int ContentItemId { get; set; }

    public int TermId { get; set; }

    public virtual ContentItems ContentItem { get; set; } = null!;

    public virtual TaxonomyTerms Term { get; set; } = null!;
}
