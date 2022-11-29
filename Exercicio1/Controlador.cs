using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Controlador
    {
        Validator validator = new Validator();
        PegaDados pegaDados = new PegaDados();
        public void ValidaDados(Dictionary<string, string> dados)
        {
           Erro erro = validator.ValidaDados(dados);
            EscreveJson(erro);
        }

        public void EscreveJson(Erro erro)
        {
            var json = JsonSerializer.Serialize(erro);
            Console.WriteLine(json);
        }

        public void Start()
        {
            pegaDados.AbreJson();
        }


    }
}
