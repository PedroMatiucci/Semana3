//referencia: https://www.codeproject.com/Articles/20592/Implementing-IEquatable-Properly

namespace Exercicio4
{
    public class Cliente : IEquatable<Cliente>
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }

        public Cliente(string nome, int cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public bool Equals(Cliente other)
        {
            if (Object.ReferenceEquals(other, null)) return false;

            if (Object.ReferenceEquals(this, other)) return true;
            return Cpf.Equals(other.Cpf);
        }
        public override int GetHashCode()
        {
            int hashProductCpf = Cpf == null ? 0 : Cpf.GetHashCode();
            return hashProductCpf;
        }
    }
}

