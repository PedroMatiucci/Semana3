using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class ClienteNaoValidado
    {
        private string nome;
        private string cpf;
        private string dataDeNascimento;
        private string rendaMensal;
        private string estadoCivil;
        private string dependentes;
        public ClienteNaoValidado(string nome, string cpf, string dataDeNascimento, string rendaMensal, string estadoCivil, string dependentes)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dataDeNascimento = dataDeNascimento;
            this.rendaMensal = rendaMensal;
            this.estadoCivil = estadoCivil;
            this.dependentes = dependentes;
        }

        public string Nome { get { return nome; } private set { } }

        public string Cpf { get { return cpf; } private set { } }

        public string DataDeNascimento { get { return dataDeNascimento; } private set { } }

        public string RendaMensal { get { return rendaMensal; } private set { } }

        public string EstadoCivil { get { return estadoCivil; } private set { } }

        public string Dependentes { get { return dependentes; } private set { } }
    }
}
