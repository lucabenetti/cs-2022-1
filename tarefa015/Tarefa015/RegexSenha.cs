using System.Text.RegularExpressions;

namespace Tarefa015
{
    public static class RegexSenha
    {
        private const string ExpressaoRegular = "^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{8,12}$";

        public static bool Validar(string valor)
        {
            var regex = new Regex(ExpressaoRegular);
            return regex.IsMatch(valor);
        }
    }
}
