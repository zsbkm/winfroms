using System.Collections.Generic;
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
    }
}
