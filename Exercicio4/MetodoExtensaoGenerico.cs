using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public static class MetodoExtensaoGenerico
    {
        public static List<T> RemoveRepetidos<T>(this List<T> lista)
        {
            return lista.Distinct().ToList();
        }
    }
}
