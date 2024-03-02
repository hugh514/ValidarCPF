using System;
using System.IO;

namespace ValidarCPF
{
    public class Historico_cpf
    {
        public string Historico()
        {
                Console.Clear();
                Console.WriteLine("=====Bem vindo ao seu histórico de CPFs gerados=====");
                string path = Path.Combine(Directory.GetCurrentDirectory(), "historico.txt");
                string texto = "\n";
                using (StreamReader sr = new StreamReader(path))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        texto += $"{linha}\n";
                    }
                }
                return texto;
        }
    }
}
