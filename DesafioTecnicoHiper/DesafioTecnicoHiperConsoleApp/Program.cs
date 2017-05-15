using DesafioTecnicoHiperClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoHiperConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Bussola bussola = new Bussola();

            string sequencia = string.Empty;

            Console.TreatControlCAsInput = true;

            Console.WriteLine("Bem vindo ao Desafio Técnico Hiper!!!");
            Console.WriteLine();
            Console.WriteLine("Informe a sequência de direções ('E' - Para Esquerda e 'D' - Para Direita) e pressione 'Enter' para obter a direção.");
            Console.WriteLine("Pressione 'Esc' para sair.");
            Console.WriteLine();

            do
            {
                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.E)
                {
                    sequencia += "E";
                }
                else if (cki.Key == ConsoleKey.D)
                {
                    sequencia += "D";
                }
                else if (cki.Key != ConsoleKey.Enter && cki.Key != ConsoleKey.Escape)
                {
                    Console.WriteLine();
                    Console.WriteLine("São aceitos apenas duas letras. ('E' - Para Esquerda e 'D' - Para Direita).");
                }

            } while (cki.Key != ConsoleKey.Escape && cki.Key != ConsoleKey.Enter);

            if (cki.Key == ConsoleKey.Enter && sequencia != string.Empty)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"A sequência digitada foi: {sequencia}");
                Console.WriteLine();
                Console.WriteLine($"Direções a seguir: {bussola.DefineOrientacao(sequencia)}");
                Console.WriteLine();
            }

            if (cki.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                Console.WriteLine("Até a próxima...");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para fechar o console.");
                Console.ReadKey();
            }
        }
    }
}