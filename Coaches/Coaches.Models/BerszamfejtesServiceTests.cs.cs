using System;
using System.Linq;
using Xunit;
using Coaches.Models;
using Coaches.Services;
using Microsoft.EntityFrameworkCore;



public class BerszamfejtesServiceTests
{
    [Fact]
    public void GetAvailableMonths_ReturnsCorrectMonths()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<MyDnndatabaseContext>()
            .UseInMemoryDatabase("TestDb")
            .Options;

        using var context = new MyDnndatabaseContext(options);

        context.Foglalasok.Add(new Foglalasok { Idopont = new DateTime(2024, 3, 15) });
        context.Foglalasok.Add(new Foglalasok { Idopont = new DateTime(2024, 3, 20) });
        context.Foglalasok.Add(new Foglalasok { Idopont = new DateTime(2024, 4, 10) });
        context.SaveChanges();

        var service = new BerszamfejtesService(context);

        // Act
        var result = service.GetAvailableMonths();

        // Assert
        Assert.Equal(2, result.Count());
        Assert.Contains("2024-03", result);
        Assert.Contains("2024-04", result);
    }
}
