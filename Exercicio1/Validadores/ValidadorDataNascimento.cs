using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Exercicio1
{
    internal class ValidadorDataNascimento : AbstractValidador
    {
        Validator validator = new Validator();

        public override string MensagemErro()
        {
            return "Por Favor Digite uma Data Valida";
        }


        public override string Nome()
        {
            return "dt_nascimento";
        }

        public override bool Verifica(string dadoVerifica)
        {
            string pattern = @"^\d{2}\/\d{2}\/\d{4}$";
            Regex rg = new Regex(pattern);
            Match m1 = rg.Match(dadoVerifica);
            while (true)
            {
                if (m1.Success == false)
                {
                    return false;
                }
                else
                {
                    DateTime dt = DateTime.Now;
                    try
                    {
                        dt = DateTime.ParseExact(dadoVerifica, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    catch (FormatException)
                    {
                        return false;

                    }
                    int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                    int dob = int.Parse(dt.ToString("yyyyMMdd"));
                    int age = (now - dob) / 10000;
                    if (age >= 18)
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
    }
}





