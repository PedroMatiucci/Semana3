namespace Exercicio1
{
    abstract class AbstractValidador
    {   
        public abstract string MensagemErro();

        public abstract bool Verifica(string dadoVerifica);

        public abstract string Nome();

    }
}
