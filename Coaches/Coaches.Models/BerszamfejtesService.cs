using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Coaches.Models;

namespace Coaches.Services
{
    public class BerszamfejtesService : IBerszamfejtesService
    {
        private readonly MyDnndatabaseContext _context;

        public BerszamfejtesService(MyDnndatabaseContext context)
        {
            _context = context;
        }

        public List<string> GetAvailableMonths()
        {
            return _context.Foglalasok
                .Where(f => f.Idopont != null)
                .Select(f => new { f.Idopont.Value.Year, f.Idopont.Value.Month })
                .AsEnumerable()
                .Select(x => $"{x.Year}-{x.Month:D2}")
                .Distinct()
                .OrderBy(h => h)
                .ToList();
        }

        public List<BerszamfejtesResult> GetBerszamfejtesAdatok(string honapFilter)
        {
            var query = from f in _context.Foglalasok
                        join e in _context.SzemelyiEdzok on f.SzemelyiEdzoId equals e.Id
                        where f.Idopont != null
                        select new { f, e };

            if (!string.IsNullOrEmpty(honapFilter) && honapFilter != "Összes")
            {
                var parts = honapFilter.Split('-');
                if (parts.Length == 2 && int.TryParse(parts[0], out int year) && int.TryParse(parts[1], out int month))
                {
                    query = query.Where(x => x.f.Idopont.Value.Year == year && x.f.Idopont.Value.Month == month);
                }
                else
                {
                    return new List<BerszamfejtesResult>(); // Érvénytelen hónapformátum
                }
            }

            return query
                .AsEnumerable() // LINQ to Objects szükséges a nullable kezeléshez
                .GroupBy(x => new { x.e.Id, x.e.Nev, x.e.Oraber })
                .Select(g => new BerszamfejtesResult
                {
                    Id = g.Key.Id,
                    Edzo = g.Key.Nev,
                    Oraber = g.Key.Oraber ?? 0,
                    FoglalasokSzama = g.Count(),
                    BruttoBer = g.Count() * (g.Key.Oraber ?? 0)
                })
                .ToList();
        }
    }

    public class BerszamfejtesResult
    {
        public int Id { get; set; }
        public string Edzo { get; set; }
        public int Oraber { get; set; }
        public int FoglalasokSzama { get; set; }
        public int BruttoBer { get; set; }
    }
}
