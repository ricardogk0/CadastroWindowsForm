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

        public FormPessoa()
        {
            InitializeComponent();           
            PreencherDataGrid();
        }

        private void PreencherDataGrid()
        {
            string connectionString = "Server=localhost;Port=5432;Database=cadastropessoa_db;User Id=postgres1;Password=123;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT codigo, nome, cnpjcpf, email, telefone FROM pessoa";

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

    }
}
