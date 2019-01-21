using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            TribonacciSolver solver = new TribonacciSolver();
            while (true)
            {
                Console.WriteLine("Ange hur lång tribonacci-sekvens du vill ha (skriv exit för att avsluta): ");
                string line = Console.ReadLine();
                if (line == "exit")
                {
                    break;
                }
                int input;
                if (!int.TryParse(line, out input))
                {
                    Console.WriteLine("Felaktig input. Skriv ett naturligt tal eller 'exit'.");
                    continue;
                }
                List<BigInteger> tribonacciSequence = solver.GetTribonacciSequence(input);
                if (tribonacciSequence == null)
                {
                    Console.WriteLine("Felaktig input. Skriv ett naturligt tal eller 'exit'.");
                    continue;
                }
                for (int i = 0; i < tribonacciSequence.Count; i++)
                {
                    Console.WriteLine(string.Format("f({0}) = {1}", i, tribonacciSequence[i]));
                }
            }
        }
    }
}
