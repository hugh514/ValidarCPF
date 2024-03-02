using System;
using ValidarCPF;

namespace InserirCPF
{
    public class Inserir_cpf
    {
        public void InserirCpf()
        {
            string escolha;
            do
            {

                Console.Clear();
                Console.WriteLine("====Bem vindo ao Verificador de CPFs====\n");
                var ValidarCPF = new validar_cpf();
                    Console.Write("Digite um CPF: ");
                    string cpf = Console.ReadLine();

                    cpf = cpf.Replace(".", "");
                    cpf = cpf.Replace("-", "");

                    if (cpf.Length != 11 ||
                        cpf == "11111111111" ||
                        cpf == "22222222222" ||
                        cpf == "33333333333" ||
                        cpf == "44444444444" ||
                        cpf == "55555555555" ||
                        cpf == "66666666666" ||
                        cpf == "77777777777" ||
                        cpf == "88888888888" ||
                        cpf == "99999999999" ||
                        cpf == "")
                    {
                        Console.WriteLine("CPF inválido");
                    }
                    else
                    {
                        string verificar = ValidarCPF.ValidarCpf(cpf);
                        Console.WriteLine(verificar);
                    }
                Console.WriteLine("\nDeseja verificar outro CPF? (S/N)");
                escolha = Console.ReadLine();

            } while (escolha.ToUpper() == "S");
        }
    }
}
