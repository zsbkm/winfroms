using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class SzemelyiEdzokFoglalasok
{
    public int Id { get; set; }

    public int? SzemelyiEdzoId { get; set; }

    public string Nev { get; set; } = null!;

    public int? DnnAzonosito { get; set; }

    public string? Sport { get; set; }

    public DateTime Idopont { get; set; }

    public string? Megjegyzes { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual SzemelyiEdzokEdzok? SzemelyiEdzo { get; set; }
}
