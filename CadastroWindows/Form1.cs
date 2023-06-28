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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoa = new List<Pessoa>();
            pessoa.Add(new Pessoa { codigo = 0});
            pessoa.Add(new Pessoa { nome = tb_nome.Text });
            pessoa.Add(new Pessoa { cpf = tb_cpf.Text });
            pessoa.Add(new Pessoa { email = tb_email.Text });
            pessoa.Add(new Pessoa { telefone = tb_tel.Text });
            MessageBox.Show("Cadastro realizado com sucesso");

            //FormCadastros formCadastros = new FormCadastros(pessoa);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            FormCadastros formCadastros = new FormCadastros();
            formCadastros.Show();
        }
    }
}
