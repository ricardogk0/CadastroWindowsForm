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
    public partial class FormPessoa : Form
    {
        string connectionString = "Server=localhost;Port=5432;Database=cadastropessoa_db;User Id=postgres1;Password=123;";

        public FormPessoa()
        {
            InitializeComponent();           
            PreencherDataGrid();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            ExcluirPessoa();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Show();
        }

        private void PreencherDataGrid()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT codigo, nome, cnpjcpf as cpf, email, telefone FROM pessoa";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void ExcluirPessoa()
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja excluir o cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectRow = dataGridView1.SelectedRows[0];
                    string codigo = selectRow.Cells["codigoDataGridViewTextBoxColumn"].Value.ToString();
                    string sql = "DELETE FROM pessoa WHERE codigo = @codigo";

                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@codigo", codigo);
                            int rowsAffected = command.ExecuteNonQuery();
                            
                            if(rowsAffected > 0)
                            {
                                MessageBox.Show("Cadastro excluido com sucesso!");
                                PreencherDataGrid();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao excluir cadastro");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
                       
        }

        private void EditarPessoa()
        {

        }

        
    }
}
