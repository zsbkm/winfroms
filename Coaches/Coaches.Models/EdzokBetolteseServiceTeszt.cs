using System;
using System.Linq;
using Coaches.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Coaches.Tests
{
    public class EdzokBetolteseServiceTests
    {
       
        [Fact]
        public void SzurtEsRendezettLista_EkezettelIsMegtalalja()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<MyDnndatabaseContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            using var context = new MyDnndatabaseContext(options);

            context.SzemelyiEdzok.AddRange(
                new SzemelyiEdzok { Nev = "Béla", Oraber = 5000 },
                new SzemelyiEdzok { Nev = "Anna", Oraber = 7000 },
                new SzemelyiEdzok { Nev = "Áron", Oraber = 6000 }
            );
            context.SaveChanges();

            var service = new EdzokBetolteseService(context);

            // Act
            var result = service.SzurtEsRendezettLista("Nev", "a");

            // Assert
            var nevek = result.Select(e => e.Nev).ToList();

            Assert.Contains("Anna", nevek);
            Assert.Contains("Áron", nevek);
            Assert.Contains("Béla", nevek); // javítva: Béla is tartalmaz 'a'-t
        }

    }
}
