using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Sqlqueries
{
    public int QueryId { get; set; }

    public string Name { get; set; } = null!;

    public string Query { get; set; } = null!;

    public string ConnectionStringName { get; set; } = null!;

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }
}
