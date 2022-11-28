using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Cliente
    {
            private string nome;
            private long cpf;
            private DateTime dataDeNascimento;
            private float rendaMensal;
            private char estadoCivil;
            private int dependentes;
            public Cliente(string nome, long cpf, DateTime dataDeNascimento, float rendaMensal, char estadoCivil, int dependentes)
            {
                this.nome = nome;
                this.cpf = cpf;
                this.dataDeNascimento = dataDeNascimento;
                this.rendaMensal = rendaMensal;
                this.estadoCivil = estadoCivil;
                this.dependentes = dependentes;
            }

            public string Nome { get { return nome; } set { nome = Nome; } }

            public long Cpf { get { return cpf; } private set { } }

            public DateTime DataDeNascimento { get { return dataDeNascimento; } private set { } }

            public float RendaMensal { get { return rendaMensal; } private set { } }

            public char EstadoCivil { get { return estadoCivil; } private set { } }

            public int Dependentes { get { return dependentes; } private set { } }

        }
}
