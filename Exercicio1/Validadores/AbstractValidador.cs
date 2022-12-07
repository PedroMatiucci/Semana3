namespace Exercicio1
{
    abstract class AbstractValidador
    {   
        public abstract string MensagemErro();

        public abstract List<string> Verifica(string dadoVerifica);

        public abstract string Nome();

    }
}
