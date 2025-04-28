using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class RedirectMessages
{
    public Guid MessageId { get; set; }

    public int? UserId { get; set; }

    public int? TabId { get; set; }

    public string MessageText { get; set; } = null!;

    public DateTime CreatedOnDate { get; set; }
}
