using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroWindows
{
    public partial class FormCadastro : Form
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        public FormCadastro()
        {
            InitializeComponent();
            Pessoa pessoa = new Pessoa();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
            MessageBox.Show("Cadastro realizado com sucesso");

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            Associar();           
        }

        private void Cadastrar()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = tb_nome.Text;
            pessoa.cpf = tb_cpf.Text;
            pessoa.email = tb_email.Text;
            pessoa.telefone = tb_tel.Text;
            pessoas.Add(pessoa);
        }

        private void Associar()
        {
            FormPessoa formCadastros = new FormPessoa(pessoas);
            formCadastros.Show();
        }
    }
}
