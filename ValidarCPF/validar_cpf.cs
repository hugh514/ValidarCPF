using System;

namespace ValidarCPF
{
    public class validar_cpf
    {
        public string ValidarCpf(string cpf)
        {
            char[] caractere = new char[10];
            char[] cpfVerif = new char[11];
            int PrimeiroDigt = 0;
            int SegundoDigit = 0;
            int peso = 0;
            int PrimDigitVerif = 0;
            int SegDigitVerif = 0;
            int CpfValido = 0;

            string DigitosUnicos = cpf.Substring(0, cpf.Length - 2);

            PrimDigitVerif = PrimeiroDigito(PrimeiroDigt,DigitosUnicos,peso,caractere,PrimDigitVerif);

            caractere[9] = char.Parse(PrimDigitVerif.ToString());

            SegDigitVerif = SegundoDigito(SegundoDigit,SegDigitVerif,caractere);

            for (int i = 0; i < caractere.Length; i++)
            {
                cpfVerif[i] = caractere[i];
            }


            cpfVerif[10] = char.Parse(SegDigitVerif.ToString());

            for (int i = 0; i < caractere.Length; i++)
            {
                if (cpfVerif[i] == cpf[i])
                {
                    CpfValido++;
                }
            }

            if (CpfValido == 10)
            {
                return "\nCPF válido";
            }
            else
            {
                return "\nCPF inválido";
            }
        }

        public int PrimeiroDigito(int PrimeiroDigito, string DigitosUnicos, int peso, char[] caractere, int PrimDigitVerif)
        {
            for (int i = 0; i < DigitosUnicos.Length; i++)
            {
                peso++;
                caractere[i] = DigitosUnicos[i];
                PrimeiroDigito += int.Parse(caractere[i].ToString()) * peso;
            }

            PrimeiroDigito %= 11;

            if (PrimeiroDigito == 10)
            {
                PrimDigitVerif = 0;
                return PrimDigitVerif;
            }
            else
            {
                PrimDigitVerif = PrimeiroDigito;
                return PrimDigitVerif;
            }

            
        }

        public int SegundoDigito(int SegundoDigito, int SegDigitVerif, char[] caractere)
        {
            for (int i = 0; i < caractere.Length; i++)
            {
                SegundoDigito += int.Parse(caractere[i].ToString()) * i;
            }
            SegundoDigito %= 11;

            if (SegundoDigito == 10)
            {
                SegDigitVerif = 0;
                return SegDigitVerif;
            }
            else
            {
                SegDigitVerif = SegundoDigito;
                return SegDigitVerif;
            }
        }
    }
}
