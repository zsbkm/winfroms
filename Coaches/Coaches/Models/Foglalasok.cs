using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class Foglalasok
{
    public int Id { get; set; }

    public int? SzemelyiEdzoId { get; set; }

    public string? Nev { get; set; }

    public int? DnnAzonosito { get; set; }

    public string? Sport { get; set; }

    public DateTime? Idopont { get; set; }

    public string? Megjegyzes { get; set; }

    public virtual SzemelyiEdzok? SzemelyiEdzo { get; set; }
}
