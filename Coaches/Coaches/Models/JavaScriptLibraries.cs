using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class JavaScriptLibraries
{
    public int JavaScriptLibraryId { get; set; }

    public int PackageId { get; set; }

    public string LibraryName { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string ObjectName { get; set; } = null!;

    public int PreferredScriptLocation { get; set; }

    public string Cdnpath { get; set; } = null!;

    public virtual Packages Package { get; set; } = null!;
}
