using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccCountryTranslations
{
    public long CountryTranslationId { get; set; }

    public Guid CountryId { get; set; }

    public string Culture { get; set; } = null!;

    public string? DisplayName { get; set; }

    public virtual HccCountries Country { get; set; } = null!;
}
