using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroWindows
{
    public class Pessoa
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public Pessoa(int codigo, string nome, string cpf, string email, string telefone)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.telefone = telefone;
        }

        public Pessoa(int codigo)
        {
            this.codigo = codigo;
        }

        public Pessoa()
        {

        }
    }
}
