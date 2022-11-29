namespace Exercicio1
{
    internal class Erro
    {
        List<string> dados = new List<string>();
        Dictionary<string, string> dicErros = new Dictionary<string, string>();

        public Erro(List<string> dados, Dictionary<string, string> dicErros)
        {
            this.dados = dados;
            this.dicErros = dicErros;
        }
    }
}
