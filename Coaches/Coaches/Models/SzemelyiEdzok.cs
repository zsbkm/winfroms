using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class SzemelyiEdzok
{
    public int Id { get; set; }

    public string? Nev { get; set; }

    public string? SzulHely { get; set; }

    public DateTime? SzulIdo { get; set; }

    public string? Telefonszam { get; set; }

    public string? Email { get; set; }

    public string? Facebook { get; set; }

    public string? Bio { get; set; }

    public string? Motto { get; set; }

    public string? Sportok { get; set; }

    public int? DnnAzonosito { get; set; }

    public string? Napszak { get; set; }

    public bool? Aktiv { get; set; }

    public string? Lakcim { get; set; }

    public int? Oraber { get; set; }

    public string? Bankszamlaszam { get; set; }

    public string? Adoazonosito { get; set; }

    public virtual ICollection<Foglalasok> Foglalasok { get; } = new List<Foglalasok>();
}
