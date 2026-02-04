using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<string> nomes = new List<string>();
            List<DateTime> datas = new List<DateTime>();
            List<string> documento = new List<string>();
            List<string> estadoCivil = new List<string>();
            List<string> telefone = new List<string>();
            List<string> endereco = new List<string>();
            List<char> sexos = new List<char>();

            char opcao;

            Console.WriteLine("----- CADASTRO -----");
            Console.WriteLine();
            do
            {
                Console.Write("Nome: ");
                nomes.Add(Console.ReadLine());

                Console.Write("Data de Nascimento: ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                datas.Add(data);

                Console.Write("CPF/RG: ");
                documento.Add(Console.ReadLine());

                Console.Write("Estado Civil: ");
                estadoCivil.Add(Console.ReadLine());

                Console.Write("Digite o Telefone: ");
                telefone.Add(Console.ReadLine());

                Console.Write("Digite o Endereco: ");
                endereco.Add(Console.ReadLine());


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
                Console.WriteLine($"Nome: {nomes[i]}");
                Console.WriteLine($"Data de Nascimento: {datas[i].ToString("dd/MM/yyyy")}");
                Console.WriteLine($"CPF/RG: {documento[i]}");
                Console.WriteLine($"Estado Civil: {estadoCivil[i]}");
                Console.WriteLine($"Telefone: {telefone[i]}");
                Console.WriteLine($"Endereco: {endereco[i]}");
                Console.WriteLine($"Sexo: {sexos[i]}");
                Console.WriteLine();
            }

        }
    }
    
}
