using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Exercicio1
{
    internal class ValidadorDependentes : AbstractValidador
    {
        Validator validator = new Validator();
        public override string MensagemErro()
        {
            return "Por Favor Digite Um Numero Entre 0 e 10";

        }

        public override string Nome()
        {
            return "dependentes";
        }

        public override bool Verifica(string dadoVerifica)
        {
            string pattern = @"\b([0-9]|10)\b";
            Regex rg = new Regex(pattern);
            Match m = rg.Match(dadoVerifica);
            if (m.Success)
            {
                return true;
            }
            else
            {
                validator.AdicionaErros(dadoVerifica, Nome(), MensagemErro());
                return false;
            }
        }

    }
}
