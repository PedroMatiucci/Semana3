using System.Text.Json;


namespace Exercicio1
{
    internal class PegaDados
    {
        Controlador controlador = new Controlador();
        public void AbreJson()
        {
            string text = File.ReadAllText(@".\json\clientes.json");
            Dictionary<string, string> dicionarioClientes = new Dictionary<string, string>();   
            using var doc = JsonDocument.Parse(text);
            JsonElement root = doc.RootElement;

            var users = root.EnumerateArray();

            while (users.MoveNext())
            {
                var user = users.Current;
                var props = user.EnumerateObject();

                while (props.MoveNext())
                {
                    var prop = props.Current;
                    string chave = prop.Name;
                    string value = prop.Value.ToString();
                    try
                    {
                        dicionarioClientes.Add(chave, value);
                    }catch(Exception ArgumentException){
                        dicionarioClientes[chave] = value;
                    }
                }
               // controlador.ValidaDados(dicionarioClientes);
            }

        }

    }
}



