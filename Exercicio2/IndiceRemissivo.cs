namespace Exercicio2
{
    internal class IndiceRemissivo
    {
        Dictionary<string, int> DicContador = new Dictionary<string, int>();
        Dictionary<string, List<int>> DicLinha = new Dictionary<string, List<int>>();
        char[] chars = { ' ', '.', ',', ';', '<', '>', ':', '\\', '/', '|', '~', '^', '´', '`', '[', ']', '{', '}', '‘', '“', '!', '@', '#', '$', '%', '&', '%', '&', '*', '(', ')', '_', '+', '=' };
        public string PathTXT { get; set; }
        public string PathIgnore { get; set; }

        public IndiceRemissivo(string PathTXT, string PathIgnore = " ")
        {
            this.PathTXT = PathTXT;
            this.PathIgnore = PathIgnore;
            ContaPalavras();
        }

        public void ContaPalavras()
        {
            try
            {
                string[] lines = File.ReadAllLines(PathTXT);
                string ignore = " ";
                if (PathIgnore != " ")
                {
                    ignore = File.ReadAllText(PathIgnore);
                }
                int i = 0;
                foreach (string line in lines)
                {
                    string[] words = line.Split(chars);
                    foreach (string word in words)
                    {
                        string w = word.Trim().ToLower();
                        if (!DicContador.ContainsKey(w))
                        {
                            if (!ignore.Contains(w))
                            {
                                DicContador.Add(w, 1);
                                List<int> listaTemp = new List<int> { i };
                                DicLinha.Add(w, listaTemp);
                            }
                        }
                        else
                        {
                            DicContador[w] += 1;
                            if (!DicLinha[w].Contains(i))
                            {
                                DicLinha[w].Add(i);
                            }
                        }
                    }
                    i++;
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void Imprime()
        {
            foreach (KeyValuePair<string, int> word in DicContador.OrderBy(key => key.Key))
            {
                string numeroLinha = string.Join(", ", DicLinha[word.Key]);
                Console.WriteLine("{0} ({1}) {2}", word.Key.ToUpper(), word.Value, numeroLinha);
            }

        }
    }
}
