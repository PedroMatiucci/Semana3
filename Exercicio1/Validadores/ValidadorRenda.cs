using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Exercicio1
{
    internal class ValidadorRenda : AbstractValidador
    {
        public override string MensagemErro()
        {
            return "Por Favor Digite Uma Renda Valida";

        }

        public override string Nome()
        {
            return "renda_mensal";
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
            else
            {

                string pattern = @"^\d+,\d{2}$";
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
}
