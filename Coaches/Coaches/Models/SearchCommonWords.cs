using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class SearchCommonWords
{
    public int CommonWordId { get; set; }

    public string CommonWord { get; set; } = null!;

    public string? Locale { get; set; }
}
