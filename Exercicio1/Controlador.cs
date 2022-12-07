using System.Text.Json;

namespace Exercicio1
{
    internal class Controlador
    {
        List<object> listaClientes = new List<object>();
        Validator validator = new Validator();
        PegaDados pegaDados = new PegaDados();
        public void ValidaDados(List<object> dados)
        {
            List<Erro> listaErros = validator.ValidaDados(dados);
            EscreveJson(listaErros);
        }

        public void EscreveJson(List<Erro> listaErro)
        {
            string fullPath = @"C:\Users\Carla\Desktop\json\jsonErros.txt";
            var jsonString = JsonSerializer.Serialize(listaErro);
            Console.WriteLine(jsonString);
            File.WriteAllText(fullPath, jsonString);

        }

        public void Start()
        {
            listaClientes = pegaDados.AbreJson();
            ValidaDados(listaClientes);

        }


    }
}
