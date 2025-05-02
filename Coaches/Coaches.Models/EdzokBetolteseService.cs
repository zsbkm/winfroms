using Coaches.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Coaches.Tests
{
    public class EdzokBetolteseService
    {
        private readonly MyDnndatabaseContext _context;

        public EdzokBetolteseService(MyDnndatabaseContext context)
        {
            _context = context;
        }

        public List<SzemelyiEdzok> SzurtEsRendezettLista(string szuro, string filterText)
        {
            string filter = RemoveDiacritics(filterText.ToLower());

            var query = _context.SzemelyiEdzok
                .AsEnumerable() // átvált memóriaoldali feldolgozásra
                .Where(x => RemoveDiacritics(x.Nev.ToLower()).Contains(filter))
                .AsQueryable();

            query = szuro switch
            {
                "Id" => query.OrderBy(x => x.Id),
                "Nev" => query.OrderBy(x => x.Nev),
                "Szulhely" => query.OrderBy(x => x.SzulHely),
                "Szulido" => query.OrderBy(x => x.SzulIdo),
                "Sportok" => query.OrderBy(x => x.Sportok),
                "Napszak" => query.OrderBy(x => x.Napszak),
                "Aktiv" => query.OrderBy(x => x.Aktiv),
                "Oraber" => query.OrderBy(x => x.Oraber),
                _ => query.OrderBy(x => x.Nev)
            };

            return query.ToList();
        }

        private static string RemoveDiacritics(string text)
        {
            return string.Concat(
                text.Normalize(NormalizationForm.FormD)
                    .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
            ).Normalize(NormalizationForm.FormC);
        }
    }
}
