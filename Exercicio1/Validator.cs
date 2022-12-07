namespace Exercicio1
{
    internal class Validator
    {
        ValidadorNome validatorNome = new ValidadorNome();
        ValidadorCpf validatorCpf = new ValidadorCpf();
        ValidadorDataNascimento validatorDataNascimento = new ValidadorDataNascimento();
        ValidadorRenda validatorRenda = new ValidadorRenda();
        ValidadorEstado validatorEstado = new ValidadorEstado();
        ValidadorDependentes validatorDependentes = new ValidadorDependentes();
        List<string> dados = new List<string>();
        Dictionary<string, string> dicErros = new Dictionary<string, string>();
        List<Erro> listaErros = new List<Erro>();

        public List<Erro> ValidaDados(List<object> dadosClientes)
        {
            foreach (ClienteNaoValidado cliente in dadosClientes)
            {
                AdicionaErros(validatorNome.Verifica(cliente.Nome));
                AdicionaErros(validatorCpf.Verifica(cliente.Cpf));
                AdicionaErros(validatorDataNascimento.Verifica(cliente.DataDeNascimento));
                AdicionaErros(validatorRenda.Verifica(cliente.RendaMensal));
                AdicionaErros(validatorEstado.Verifica(cliente.EstadoCivil));
                AdicionaErros(validatorDependentes.Verifica(cliente.Dependentes));
                Erro erro = new Erro(dados, dicErros);
                listaErros.Add(erro);
                dados.Clear();
                dicErros.Clear();
            }
            
            return listaErros;
        }

        public void AdicionaErros(List<string> dadosValidados)
        {
            if (dadosValidados != null)
            {
                dados.Add(dadosValidados[0]);
                dicErros.Add(dadosValidados[1], dadosValidados[2]);
            }
        }


    }
}