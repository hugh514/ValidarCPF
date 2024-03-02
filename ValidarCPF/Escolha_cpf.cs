using InserirCPF;
using System;
using ValidarCPF;


namespace EscolhaCPF
{
    public class Escolha_cpf
    {
        public void escolhaCpf()
        {
            int escolha = 0;
            do
            {
                try
                {
                    var inserir_cpf = new Inserir_cpf();
                    var gerar_cpf = new Gerar_CPF();
                    var historico_cpf = new Historico_cpf();
                    Console.Clear();
                    Console.WriteLine("Seja bem vindo(a)\nO que você deseja hoje?\n");
                    Console.WriteLine("1 - Validar CPF\n2 - Gerar CPF\n3 - Histórico de CPFs Gerados\n4 - Sair");
                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            inserir_cpf.InserirCpf();
                            break;
                        case 2:
                            gerar_cpf.GerarCpf();
                            break;
                        case 3:
                            Console.WriteLine(historico_cpf.Historico());
                            Console.WriteLine("Digite qualquer tecla pra voltar...");
                            Console.ReadKey();
                            break;
                        case 4:
                            continue;
                        default:
                            Console.WriteLine("Escolha indisponivel");
                            break;
                    }
                    Console.WriteLine("\nEspere um pouco...");
                    Thread.Sleep(4000);
                }
                catch (Exception erro)
                {
                    Console.WriteLine($"Está dando o erro '{erro.Message}'");
                }
            }while (escolha != 4);

        }
    }
}
