using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabicToRoman
{
    class Program
    {
        private static StringBuilder romanBuilder= new StringBuilder();
        private readonly static Dictionary<int, string> ArabicAux = new Dictionary<int, string>() {
                                                                                                    { 3000, "MMM" },
                                                                                                    { 2000, "MM" },
                                                                                                    { 1000, "M" },
                                                                                                    { 900, "CM" },
                                                                                                    { 800, "DCCC" },
                                                                                                    { 700, "DCC" },
                                                                                                    { 600, "DC" },
                                                                                                    { 500, "D" },
                                                                                                    { 400, "CD" },
                                                                                                    { 300, "CCC" },
                                                                                                    { 200, "CC" },
                                                                                                    { 100, "C" },
                                                                                                    { 90, "XC" },
                                                                                                    { 80, "LXXX" },
                                                                                                    { 70, "LXX" },
                                                                                                    { 60, "LX" },
                                                                                                    { 50, "L" },
                                                                                                    { 40, "XL" },
                                                                                                    { 30, "XXX" },
                                                                                                    { 20, "XX" },
                                                                                                    { 10, "X" },
                                                                                                    { 9, "IX" },
                                                                                                    { 8, "VIII" },
                                                                                                    { 7, "VII" },
                                                                                                    { 6, "VI" },
                                                                                                    { 5, "V" },
                                                                                                    { 4, "IV" },
                                                                                                    { 3, "III" },
                                                                                                    { 2, "II" },
                                                                                                    { 1, "I" },
                                                                                                    };
        static void Main(string[] args)
        {
            Console.WriteLine("Arábico para Romano");
            Console.WriteLine("Digite um número e aperte ENTER:");
            int numeroArabico = 0;
            int.TryParse(Console.ReadLine(), out numeroArabico);
            if (numeroArabico == 0)
            {
                Console.WriteLine("Número inválido...");
                Console.Read();
            }
            else
            {
                toRoman(numeroArabico);
                Console.WriteLine(romanBuilder.ToString());
                Console.WriteLine("ENTER para sair...");
                Console.Read();
            }
        }

        public static void toRoman(int arabic)
        {
            int mod=0;
            foreach (KeyValuePair<int, string> item in ArabicAux)
            {
                if (arabic / item.Key > 0)
                {
                    romanBuilder.Append($"{item.Value}");
                    mod = arabic % item.Key;
                    if (mod > 0)
                    {
                        toRoman(mod);
                    }
                    break;
                }
            }
        }
    }
}
