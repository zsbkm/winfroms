using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class TaxonomyVocabularyTypes
{
    public int VocabularyTypeId { get; set; }

    public string VocabularyType { get; set; } = null!;

    public virtual ICollection<TaxonomyVocabularies> TaxonomyVocabularies { get; } = new List<TaxonomyVocabularies>();
}
