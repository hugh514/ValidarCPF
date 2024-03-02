using System;
using System.IO;

namespace ValidarCPF
{
    public class Gerar_CPF
    {
        public void GerarCpf()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "historico.txt");
            string escolha = "";
            do
            {
                var historico = new Historico_cpf();
                Console.Clear();
                Console.WriteLine("====Bem vindo ao Gerador de CPFs====\n");
                Random random = new Random();
                var validarCpf = new validar_cpf();
                int PrimeiroDigit = 0;
                string DigitosUnicos = "";
                int peso = 0;
                char[] caractere = new char[10];
                int primDigtVerif = 0;
                int segundoDigito = 0;
                int segDigtVerif = 0;
                string[] cpfVerif = new string[11];

                for (int i = 0; i < 9; i++)
                {
                    DigitosUnicos += random.Next(10).ToString();
                }
                primDigtVerif = validarCpf.PrimeiroDigito(PrimeiroDigit, DigitosUnicos, peso, caractere, primDigtVerif);

                caractere[9] = char.Parse(primDigtVerif.ToString());

                segDigtVerif = validarCpf.SegundoDigito(segundoDigito, segDigtVerif, caractere);

                for (int i = 0; i < caractere.Length; i++)
                {
                    cpfVerif[i] = caractere[i].ToString();
                }


                cpfVerif[10] = segDigtVerif.ToString();

                string cpf = string.Join("", cpfVerif);

                cpf = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";

                Console.WriteLine($"\nO CPF Gerado foi: {cpf}");
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(cpf);
                }
                Console.WriteLine("\nDeseja gerar outro CPF? (S/N)");
                escolha = Console.ReadLine();
            } while (escolha.ToUpper() == "S");

        }
    }
}
