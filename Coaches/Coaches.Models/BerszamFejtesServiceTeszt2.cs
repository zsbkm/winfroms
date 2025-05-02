using System;
using System.Linq;
using Coaches.Models;
using Coaches.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Coaches.Tests
{
    public class BerszamFejtesServiceTeszt2
    {
        [Fact]
        public void GetBerszamfejtesAdatok_TobbEdzoUgyanarraAHonapra_MindkettoSzerepel()
        {
            // Arrange – in-memory adatbázis konfigurálása
            var options = new DbContextOptionsBuilder<MyDnndatabaseContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            using var context = new MyDnndatabaseContext(options);

            // Tesztadatok – két külön edző, különböző foglalásszámmal
            context.SzemelyiEdzok.AddRange(
                new SzemelyiEdzok { Id = 1, Nev = "Kiss Péter", Oraber = 5000 },
                new SzemelyiEdzok { Id = 2, Nev = "Nagy Anna", Oraber = 6000 }
            );

            context.Foglalasok.AddRange(
                new Foglalasok { SzemelyiEdzoId = 1, Idopont = new DateTime(2024, 5, 10) },
                new Foglalasok { SzemelyiEdzoId = 2, Idopont = new DateTime(2024, 5, 15) },
                new Foglalasok { SzemelyiEdzoId = 2, Idopont = new DateTime(2024, 5, 20) }
            );

            context.SaveChanges();

            var service = new BerszamfejtesService(context);

            // Act – lekérjük az összesítést májusra
            var result = service.GetBerszamfejtesAdatok("2024-05");

            // Assert – 2 eredményt várunk
            Assert.Equal(2, result.Count);

            var peter = result.FirstOrDefault(r => r.Edzo == "Kiss Péter");
            var anna = result.FirstOrDefault(r => r.Edzo == "Nagy Anna");

            Assert.NotNull(peter);
            Assert.Equal(1, peter.FoglalasokSzama);
            Assert.Equal(5000, peter.Oraber);
            Assert.Equal(5000, peter.BruttoBer);

            Assert.NotNull(anna);
            Assert.Equal(2, anna.FoglalasokSzama);
            Assert.Equal(6000, anna.Oraber);
            Assert.Equal(12000, anna.BruttoBer);
        }
    }
}
