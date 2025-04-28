using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class MetaData
{
    public int MetaDataId { get; set; }

    public string MetaDataName { get; set; } = null!;

    public string? MetaDataDescription { get; set; }

    public virtual ICollection<ContentItemsMetaData> ContentItemsMetaData { get; } = new List<ContentItemsMetaData>();
}
