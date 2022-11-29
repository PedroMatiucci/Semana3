using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Exercicio1
{
    internal class ValidadorRenda : AbstractValidador
    {
        Validator validator = new Validator();
        public override string MensagemErro()
        {
            return "Por Favor Digite Uma Renda Valida";

        }

        public override string Nome()
        {
            return "renda_mensal";
        }

        public override bool Verifica(string dadoVerifica)
        {
            string pattern = @"^\d+,\d{2}$";
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
