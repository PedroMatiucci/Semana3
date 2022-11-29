namespace Exercicio1
{
    internal class ValidadorNome : AbstractValidador
    {
        Validator validator = new Validator();
        public override string MensagemErro()
        {
            return "Erro Seu Nome Precisa Ter Mais de 5 Caracteres";
        }

        public override string Nome()
        {
            return "nome";
        }

        public override bool Verifica(string dadoVerifica)
        {
            if (dadoVerifica.Length < 5)
            {
                validator.AdicionaErros(dadoVerifica, Nome(), MensagemErro());
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
