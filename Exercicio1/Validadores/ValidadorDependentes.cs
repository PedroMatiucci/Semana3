using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Exercicio1
{
    internal class ValidadorDependentes : AbstractValidador
    {
        public override string MensagemErro()
        {
            return "Por Favor Digite Um Numero Entre 0 e 10";

        }

        public override string Nome()
        {
            return "dependentes";
        }

        public override List<string>? Verifica(string dadoVerifica)
        {
            List<string> result = new List<string>();
            if (dadoVerifica == null)
            {
                result.Add(dadoVerifica);
                result.Add(Nome());
                result.Add(MensagemErro());
                return result;
            }
            string pattern = @"\b([0-9]|10)\b";
            Regex rg = new Regex(pattern);
            Match m = rg.Match(dadoVerifica);
            if (m.Success)
            {
                return null;
            }
            else
            {
                result.Add(dadoVerifica);
                result.Add(Nome());
                result.Add(MensagemErro());
                return result;
            }
        }

    }
}
