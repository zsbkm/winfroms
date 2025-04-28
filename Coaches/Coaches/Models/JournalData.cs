using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class JournalData
{
    public int JournalDataId { get; set; }

    public int JournalId { get; set; }

    public string JournalXml { get; set; } = null!;

    public virtual Journal Journal { get; set; } = null!;
}
