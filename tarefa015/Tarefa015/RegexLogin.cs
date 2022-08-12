using System.Text.RegularExpressions;

namespace Tarefa015
{
    public static class RegexLogin
    {
        private const string ExpressaoRegular = "^[a-zA-Z0-9!@#$%^&*()_+-\\\\\\/\\[\\]{};':\\\"\\|,.<>?]{5,30}$";

        public static bool Validar(string valor)
        {
            var regex = new Regex(ExpressaoRegular);
            return regex.IsMatch(valor);
        }
    }
}
