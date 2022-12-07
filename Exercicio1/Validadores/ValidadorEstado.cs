using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Exercicio1
{
    internal class ValidadorEstado : AbstractValidador
    {
        public override string MensagemErro()
        {
            return "Por Favor Digite Um Estado Valido";

        }

        public override string Nome()
        {
            return "estado_civil";
        }

        public override List<string>? Verifica(string dadoVerifica)
        {
            List<string> result = new List<string>();
            if(dadoVerifica == null)
            {
                result.Add(dadoVerifica);
                result.Add(Nome());
                result.Add(MensagemErro());
                return result;
            }
            string pattern = @"^[CSVD]$";
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
