using Xunit;
using Coaches.Validators;


namespace Coaches.Tests
{
    public class FormEditValidatorTests
    {
        [Theory]
        [InlineData("Kovács Anna", "anna@example.com", "5000", true, true)]    // helyes
        [InlineData("", "anna@example.com", "5000", true, false)]              // név hiányzik
        [InlineData("Kovács", "hibás email", "5000", true, false)]             // rossz email
        [InlineData("Kovács", "anna@example.com", "-100", true, false)]        // negatív órabér
        [InlineData("Kovács", "anna@example.com", "5000", false, false)]       // nincs bepipálva az Aktív
        public void ValidateAll_ReturnsExpected(
            string name, string email, string oraber, bool aktiv, bool expected)
        {
            var result = FormEditValidator.ValidateAll(name, email, oraber, aktiv);
            Assert.Equal(expected, result);
        }
    }
}
