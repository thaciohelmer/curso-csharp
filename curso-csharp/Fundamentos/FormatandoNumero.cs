using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1")); //Formata uma com uma casa decimal
            Console.WriteLine(valor.ToString("C")); //Formata com moeda
            Console.WriteLine(valor.ToString("P")); // Formata com percentual
            Console.WriteLine(valor.ToString("#.##")); // Formata casas decimais

            CultureInfo cultura = new CultureInfo("en-US"); //Formata no padrão da moeda escolida
            Console.WriteLine(valor.ToString("C2", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));// Adiciona zero a esquerda
        }
    }
}
