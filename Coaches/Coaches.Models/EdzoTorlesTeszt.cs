using Xunit;
using Coaches.Models;
using Microsoft.EntityFrameworkCore;
using Coaches.Services;
using System;

namespace Coaches.Tests
{
    public class EdzoTorlesTests
    {
        [Fact]
        public void EdzoTorlesTeszt()
        {
            var options = new DbContextOptionsBuilder<MyDnndatabaseContext>()
                .UseInMemoryDatabase("TorlesTesztDb")
                .Options;

            using var context = new MyDnndatabaseContext(options);

            var edzo = new SzemelyiEdzok { Id = 1, Nev = "Teszt Edző", Aktiv = true };
            var foglalas = new Foglalasok { SzemelyiEdzoId = 1, Idopont = DateTime.Now };

            context.SzemelyiEdzok.Add(edzo);
            context.Foglalasok.Add(foglalas);
            context.SaveChanges();

            var service = new EdzoTorlesService(context);
            var result = service.ProbalTorolni(1);

            var aktualis = context.SzemelyiEdzok.Find(1);

            Assert.True(result);
            Assert.NotNull(aktualis);
            Assert.False(aktualis.Aktiv); // mert szerepelt foglalásban → csak elrejtve
        }
    }
}
