using System;
using System.Globalization;
using System.Collections.Generic;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<string> nomes = new List<string>();
            List<int> idades = new List<int>();
            List<double> salarios = new List<double>();
            List<char> sexos = new List<char>();

            char opcao;

            Console.WriteLine("----- CADASTRO -----");

            do
            {
                Console.Write("Nome: ");
                nomes.Add(Console.ReadLine());

                Console.Write("Idade : ");
                idades.Add(int.Parse(Console.ReadLine()));

                Console.Write("Salario : ");
                salarios.Add(double.Parse(Console.ReadLine(), CI));

                Console.Write("Digite o sexo (M/F): ");
                sexos.Add(char.Parse(Console.ReadLine()));

                Console.Write("\nDeseja cadastrar outra pessoa? (s/n): ");
                opcao = char.Parse(Console.ReadLine().ToLower());

                Console.WriteLine();

            } while (opcao == 's');

            Console.WriteLine("---- CADASTROS REALIZADOS ----\n");

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Nome   : {nomes[i]}");
                Console.WriteLine($"Idade  : {idades[i]} anos");
                Console.WriteLine($"Salário: R$ {salarios[i].ToString("F3", CI)}");
                Console.WriteLine($"Sexo   : {sexos[i]}");
                Console.WriteLine();
            }

        }
    }
    
}
