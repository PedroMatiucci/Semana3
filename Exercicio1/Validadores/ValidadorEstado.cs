using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Exercicio1
{
    internal class ValidadorEstado : AbstractValidador
    {
        Validator validator = new Validator();
        public override string MensagemErro()
        {
            return "Por Favor Digite Um Estado Valido";

        }

        public override string Nome()
        {
            return "estado_civil";
        }

        public override bool Verifica(string dadoVerifica)
        {
            string pattern = @"^[CSVD]$";
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
