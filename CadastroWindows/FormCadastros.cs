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
    public partial class FormCadastros : Form
    {
        private List<Pessoa> pessoas;

        public FormCadastros()
        {
            InitializeComponent();
            ConfiguraDataGridView();
            DataGridView();
        }

        private void DataGridView()
        {

            dataGridView1.DataSource = pessoas;
            
            //dataGridView1.Columns.Add("cl_nome", "Nome");
            //dataGridView1.Columns["cl_nome"].DataPropertyName = "Nome";
            //Controls.Add(dataGridView1);
        }

        private void ConfiguraDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.Name = "cl_nome";
            colunaNome.HeaderText = "Nome";
            colunaNome.DataPropertyName = "Nome";
            dataGridView1.Columns.Add(colunaNome);
        }

    }
}
