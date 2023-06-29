using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CadastroWindows
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            AbrirForm();
        }

        private void AbrirForm()
        {
            FormPessoa formPessoa = new FormPessoa();
            formPessoa.Show();
        }

        private void Cadastrar()
        {
            string connectionString = "Server=localhost;Port=5432;Database=cadastropessoa_db;User Id=postgres1;Password=123;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO pessoa (codigo, nome, cnpjcpf, email, telefone) VALUES (@codigo, @tb_nome.Text, @tb_cpf.Text, @tb_email.Text, @tb_tel.Text)";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@codigo", tb_cod.Text);
                    command.Parameters.AddWithValue("@tb_nome.Text", tb_nome.Text);
                    command.Parameters.AddWithValue("@tb_cpf.Text", tb_cpf.Text);
                    command.Parameters.AddWithValue("@tb_email.Text", tb_email.Text);
                    command.Parameters.AddWithValue("@tb_tel.Text", tb_tel.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao realizar o cadastro.");
                    }
                }
            }
        }
    }
}
