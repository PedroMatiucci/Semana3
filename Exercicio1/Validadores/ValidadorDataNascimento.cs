using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Exercicio1
{
    internal class ValidadorDataNascimento : AbstractValidador
    {
        public override string MensagemErro()
        {
            return "Por Favor Digite uma Data Valida";
        }


        public override string Nome()
        {
            return "dt_nascimento";
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
            string pattern = @"^\d{2}\/\d{2}\/\d{4}$";
            Regex rg = new Regex(pattern);
            Match m1 = rg.Match(dadoVerifica);
            while (true)
            {
                if (m1.Success == false)
                {
                    result.Add(dadoVerifica);
                    result.Add(Nome());
                    result.Add(MensagemErro());
                    return result;
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
                        result.Add(dadoVerifica);
                        result.Add(Nome());
                        result.Add(MensagemErro());
                        return result;

                    }
                    int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                    int dob = int.Parse(dt.ToString("yyyyMMdd"));
                    int age = (now - dob) / 10000;
                    if (age >= 18)
                    {
                        return null;
                    }
                    else
                    {
                        result.Add(dadoVerifica);
                        result.Add(Nome());
                        result.Add(MensagemErro());
                        return result; ;
                    }
                }
            }
        }
    }
}





