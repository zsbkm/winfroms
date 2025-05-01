using System.Text.RegularExpressions;

namespace Coaches.Validators
{
    public static class FormEditValidator
    {
        public static bool CheckName(string name)
            => !string.IsNullOrEmpty(name);

        public static bool CheckEmail(string email)
            => Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w+$");

        public static bool CheckOraber(string input)
            => int.TryParse(input, out int result) && result > 0;

        public static bool ValidateAll(string name, string email, string oraber, bool aktiv)
        {
            return CheckName(name)
                && CheckEmail(email)
                && CheckOraber(oraber)
                && aktiv;
        }
    }
}
