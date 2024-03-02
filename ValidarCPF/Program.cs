using EscolhaCPF;
using InserirCPF;
using System;

namespace ValidarCPF
{
    class Program
    {
        static void Main(string[] args)
        {
            var escolha = new Escolha_cpf();
            escolha.escolhaCpf();
        }
    }
}