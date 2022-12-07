namespace Exercicio1
{
    internal class Erro
    {
        public Erro(List<string> dados, Dictionary<string, string> dicErros)
        {
            this.Dados = dados.ToList();
            this.DicErros = dicErros.ToDictionary(t => t.Key, t => t.Value);

        }

        public List<string> Dados { get; set; }

        public Dictionary<string,string> DicErros { get; set; }
    }
}
