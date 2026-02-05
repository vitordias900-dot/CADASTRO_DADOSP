using CADASTRO_DADOS;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<Pessoa> pessoas = new List<Pessoa>();
            char opcao;

            Console.WriteLine("----- CADASTRO -----\n");

            do
            {
                Pessoa p = new Pessoa();
                p.Endereco = new Endereco();

                Console.Write("Nome: ");
                p.Nome = Console.ReadLine();

                Console.Write("Data de Nascimento: ");
                p.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("CPF/RG: ");
                p.Documento = Console.ReadLine();

                Console.Write("Estado Civil: ");
                p.EstadoCivil = Console.ReadLine();

                Console.Write("Telefone: ");
                p.Telefone = Console.ReadLine();

                Console.Write("Email: ");
                p.Email = Console.ReadLine();

                Console.Write("Sexo (M/F): ");
                p.Sexo = char.Parse(Console.ReadLine().ToUpper());

                // chama o método do endereço
                p.Endereco.LerEndereco();

                pessoas.Add(p);

                Console.Write("\nDeseja cadastrar outra pessoa? (s/n): ");
                opcao = char.Parse(Console.ReadLine().ToLower());

                Console.WriteLine();

            } while (opcao == 's');

            Console.WriteLine("\n---- CADASTROS REALIZADOS ----\n");

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Nome: {p.Nome}");
                Console.WriteLine($"Nascimento: {p.DataNascimento:dd/MM/yyyy}");
                Console.WriteLine($"CPF/RG: {p.Documento}");
                Console.WriteLine($"Estado Civil: {p.EstadoCivil}");
                Console.WriteLine($"Telefone: {p.Telefone}");
                Console.WriteLine($"Email: {p.Email}");
                Console.WriteLine($"Sexo: {p.Sexo}");
                Console.WriteLine($"Endereço: {p.Endereco.Tipo} {p.Endereco.Nome}, Nº {p.Endereco.Numero}");
                Console.WriteLine();
            }
        }
    }
}
