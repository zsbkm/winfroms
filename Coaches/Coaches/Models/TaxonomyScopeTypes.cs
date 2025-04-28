using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class TaxonomyScopeTypes
{
    public int ScopeTypeId { get; set; }

    public string? ScopeType { get; set; }

    public virtual ICollection<TaxonomyVocabularies> TaxonomyVocabularies { get; } = new List<TaxonomyVocabularies>();
}
