using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Coaches.Models;
using Coaches.Services;

namespace Coaches.Tests
{
    public class SzemelyiEdzoFelvetelTest
    {
        [Fact]
        public void AddEdzo_HozzaadjaAzEdzotAzAdatbazishoz()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<MyDnndatabaseContext>()
                .UseInMemoryDatabase("EdzoFelvetelTestDb")
                .Options;

            using var context = new MyDnndatabaseContext(options);

            var service = new SzemelyiEdzoService(context);
            string nev = "Kovács Dániel";
            int oraber = 7000;

            // Act
            service.AddEdzo(nev, oraber);

            // Assert
            var edzo = context.SzemelyiEdzok.FirstOrDefault();
            Assert.NotNull(edzo);
            Assert.Equal(nev, edzo.Nev);
            Assert.Equal(oraber, edzo.Oraber);
        }
    }
}
