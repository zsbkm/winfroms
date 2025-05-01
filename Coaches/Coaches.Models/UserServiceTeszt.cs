using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Coaches.Models;
using Coaches.Services;

namespace Coaches.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void SearchByUsername_ReturnsMatchingUsers()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<MyDnndatabaseContext>()
                .UseInMemoryDatabase("UserSearchTestDb")
                .EnableSensitiveDataLogging()
                .Options;

            using var context = new MyDnndatabaseContext(options);

            context.Users.AddRange(
                new Users
                {
                    UserId = 1,
                    Username = "john.doe",
                    DisplayName = "John Doe",
                    FirstName = "John",
                    LastName = "Doe",
                    CreatedOnDate = DateTime.Now
                },
                new Users
                {
                    UserId = 2,
                    Username = "jane.smith",
                    DisplayName = "Jane Smith",
                    FirstName = "Jane",
                    LastName = "Smith",
                    CreatedOnDate = DateTime.Now
                },
                new Users
                {
                    UserId = 3,
                    Username = "johnny.appleseed",
                    DisplayName = "Johnny Appleseed",
                    FirstName = "Johnny",
                    LastName = "Appleseed",
                    CreatedOnDate = DateTime.Now
                }
            );

            context.SaveChanges();

            var service = new UserService(context);

            // Act
            var result = service.SearchByUsername("john");

            // Assert
            var usernames = result.Select(r => r.Username).ToList();
            Assert.Equal(2, usernames.Count);
            Assert.Contains("john.doe", usernames, StringComparer.OrdinalIgnoreCase);
            Assert.Contains("johnny.appleseed", usernames, StringComparer.OrdinalIgnoreCase);
        }
    }
}
