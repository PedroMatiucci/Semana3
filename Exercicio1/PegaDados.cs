using System.Reflection.Metadata;
using System.Text.Json;


namespace Exercicio1
{
    internal class PegaDados
    {
        List<object> listaCliente = new List<object>();

        public List<object> AbreJson()
        {
            string text = File.ReadAllText(@".\json\clientes.json");
            using var doc = JsonDocument.Parse(text);
            List<string> listaDados = new List<string>();
            JsonElement root = doc.RootElement;

            var clientes = root.EnumerateArray();

            while (clientes.MoveNext())
            {
                var cliente = clientes.Current;
                var props = cliente.EnumerateObject();

                while (props.MoveNext())
                {
                    var prop = props.Current;
                    listaDados.Add(prop.Value.ToString());
                }
                ClienteNaoValidado clinteTemp = new ClienteNaoValidado(listaDados[0], listaDados[1], listaDados[2], listaDados[3], listaDados[4], listaDados[5]);
                listaDados.Clear();
                listaCliente.Add(clinteTemp);

            }
            return listaCliente;

        }
    }
}



