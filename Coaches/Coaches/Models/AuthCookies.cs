using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class AuthCookies
{
    public int CookieId { get; set; }

    public string CookieValue { get; set; } = null!;

    public DateTime ExpiresOn { get; set; }

    public int UserId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
