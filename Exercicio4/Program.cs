// See https://aka.ms/new-console-template for more information
using Exercicio4;


List<string> listastring = new List<string>() {"a", "teste", "banana", "teste"};
List<int> listaint = new List<int> { 0, 1, 2, 3, 4, 3, 5 };
listaint = listaint.RemoveRepetidos();
for(int i = 0; i < listaint.Count; i++)
{
    Console.WriteLine(listaint[i]);
}
listastring = listastring.RemoveRepetidos();
for (int i = 0; i < listastring.Count; i++)
{
    Console.WriteLine(listastring[i]);
}


Cliente cliente1 = new Cliente("teste", 1234);
Cliente cliente2 = new Cliente("teste", 12345);
Cliente cliente3 = new Cliente("pedro", 12346);
Cliente cliente4 = new Cliente("pedro", 1234);
List<Cliente> lista = new List<Cliente>() { cliente1, cliente2, cliente3, cliente4 };
lista = lista.RemoveRepetidos();
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i].Cpf);
}



