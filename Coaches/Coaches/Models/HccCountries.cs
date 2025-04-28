using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccCountries
{
    public Guid CountryId { get; set; }

    public string? CultureCode { get; set; }

    public string? SystemName { get; set; }

    public string? IsoCode { get; set; }

    public string? IsoAlpha3 { get; set; }

    public string? IsoNumeric { get; set; }

    public string? PostalCodeValidationRegex { get; set; }

    public virtual ICollection<HccCountryTranslations> HccCountryTranslations { get; } = new List<HccCountryTranslations>();

    public virtual ICollection<HccRegions> HccRegions { get; } = new List<HccRegions>();
}
