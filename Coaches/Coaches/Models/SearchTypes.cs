using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class SearchTypes
{
    public int SearchTypeId { get; set; }

    public string SearchTypeName { get; set; } = null!;

    public string SearchResultClass { get; set; } = null!;

    public bool? IsPrivate { get; set; }
}
