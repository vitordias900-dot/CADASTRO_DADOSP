using System;

namespace CADASTRO_DADOS
{
    class Endereco
    {
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }

        public void LerEndereco()
        {
            Console.Write("Rua ou Av ? ");
            char opcao = char.Parse(Console.ReadLine().ToUpper());

            if (opcao == 'R')
            {
                Tipo = "Rua";
                Console.Write("Rua: ");
                Nome = Console.ReadLine();
            }
            else
            {
                Tipo = "Avenida";
                Console.Write("Avenida: ");
                Nome = Console.ReadLine();
            }

            Console.Write("Número: ");
            Numero = int.Parse(Console.ReadLine());
        }
    }
}


