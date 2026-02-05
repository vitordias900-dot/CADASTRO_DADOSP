using System;
using System.Collections.Generic;
using System.Text;

namespace CADASTRO_DADOS
{


    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Documento { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public char Sexo { get; set; }

        public Endereco Endereco { get; set; }

    }
}
    