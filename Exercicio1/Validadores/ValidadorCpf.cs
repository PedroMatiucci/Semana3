using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Exercicio1
{
    internal class ValidadorCpf : AbstractValidador
    {
        Validator validator = new Validator();
        public override string MensagemErro()
        {
            return "Cpf Invalido";
        }

        public override string Nome()
        {
            return "cpf";
        }

        public override bool Verifica(string dadoVerifica)
        {
            string pattern = @"^\d{11}$";
            Regex rg = new Regex(pattern);
            Match m = rg.Match(dadoVerifica);
            if (m.Success)
            {
                pattern = @"^(\d\d){0,11}1$";
                rg = new Regex(pattern);
                m = rg.Match(dadoVerifica);
                if (m.Success)
                {
                    if (DigitoVerificador(dadoVerifica))
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
            validator.AdicionaErros(dadoVerifica, Nome(), MensagemErro());
            return false;
        }
        public bool DigitoVerificador(string dadoVerifica)
        {
            int j = int.Parse(dadoVerifica[9].ToString());
            int k = int.Parse(dadoVerifica[10].ToString());
            int valor;
            int soma = 0;
            int multi = 10;
            for (int i = 0; i < 9; i++)
            {
                valor = int.Parse(dadoVerifica[i].ToString());
                soma += (valor * multi);
                multi--;
            }
            if (soma % 11 == 0 || soma % 11 == 1)
            {
                if (j != 0)
                {
                    return false;
                }
            }
            else if (2 <= soma % 11 && soma % 11 <= 10)
            {
                if (j != (11 - soma % 11))
                {
                    return false;
                }
            }
            multi = 11;
            for (int i = 0; i < 10; i++)
            {
                valor = int.Parse(dadoVerifica[i].ToString());
                soma += (valor * multi);
                multi--;
            }
            if (soma % 11 == 0 || soma % 11 == 1)
            {
                if (k != 0)
                {
                    return false;
                }
            }
            else if (2 <= soma % 11 && soma % 11 <= 10)
            {
                if (k != (11 - (soma % 11)))
                {
                    return false;
                }
            }
            return true;

        }
    }
}
