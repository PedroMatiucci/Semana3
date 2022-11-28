namespace Exercicio3
{
    internal static class MetodosExtensao
    {
        public static bool IsArmstrong(this int valor)
        {
            string valorString = valor.ToString();
            int tamanhoNumero = valorString.Length;
            double somaNumero = 0;
            int numero;
            for (int i = 0; i < tamanhoNumero; i++)
            {
                numero = int.Parse(valorString[i].ToString());
                somaNumero = somaNumero + Math.Pow(numero, tamanhoNumero);
            }
            Console.WriteLine(somaNumero == valor);
            return somaNumero == valor;
        }

        public static void ImprimeNumeros(this int valor)
        {
            string valorString;
            int tamanhoNumero = 0;
            double somaNumero = 0;
            int numero;
            for (int j = 0; j < 10000; j++)
            {
                valorString = j.ToString();
                tamanhoNumero = valorString.Length;
                somaNumero = 0;
                numero = 0;
                for (int i = 0; i < tamanhoNumero; i++)
                {
                    numero = int.Parse(valorString[i].ToString());
                    somaNumero = somaNumero + Math.Pow(numero, tamanhoNumero);
                }
                if (somaNumero == j)
                {
                    Console.WriteLine(j);
                }

            }
        }

    }
}
