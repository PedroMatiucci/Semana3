namespace Exercicio1
{
    internal class ValidadorNome : AbstractValidador
    {
        public override string MensagemErro()
        {
            return "Erro Seu Nome Precisa Ter Mais de 5 Caracteres";
        }

        public override string Nome()
        {
            return "nome";
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
            if (dadoVerifica.Length < 5)
            {
                result.Add(dadoVerifica);
                result.Add(Nome());
                result.Add(MensagemErro());
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
