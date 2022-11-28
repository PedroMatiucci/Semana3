using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Controlador
    {
        Validator validator = new Validator();
        public void ValidaDados(Dictionary<string, string> dados)
        {
            validator.ValidaDados(dados);
        }
    }
}
