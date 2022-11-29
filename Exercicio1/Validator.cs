using static Exercicio1.ValidadorNome;

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


        public Erro ValidaDados(Dictionary<string, string> dicDados)
        {
            validatorNome.Verifica(dicDados["nome"]);
            validatorCpf.Verifica(dicDados["cpf"]);
            validatorDataNascimento.Verifica(dicDados["dt_nascimento"]);
            validatorRenda.Verifica(dicDados["renda_mensal"]);
            validatorEstado.Verifica(dicDados["estado_civil"]);
            validatorDependentes.Verifica(dicDados["dependentes"]);
            Erro erro = new Erro(dados, dicErros);
            dados.RemoveRange(0, dados.Count);
            foreach(KeyValuePair<string,string> valor in dicErros)
            {
                dicErros.Remove(valor.Key);
            }
            return erro;
            
        }

        public void AdicionaErros(string dado, string nomeCampo, string mensagemErro)
        {
            dados.Add(dado);
            dicErros.Add(nomeCampo, mensagemErro);
        } 


    }
}