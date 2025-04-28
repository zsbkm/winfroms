using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class TaxonomyVocabularies
{
    public int VocabularyId { get; set; }

    public int VocabularyTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int Weight { get; set; }

    public int? ScopeId { get; set; }

    public int ScopeTypeId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsSystem { get; set; }

    public virtual TaxonomyScopeTypes ScopeType { get; set; } = null!;

    public virtual ICollection<TaxonomyTerms> TaxonomyTerms { get; } = new List<TaxonomyTerms>();

    public virtual TaxonomyVocabularyTypes VocabularyType { get; set; } = null!;
}
