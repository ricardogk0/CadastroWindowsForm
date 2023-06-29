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
    public partial class FormPessoa : Form
    {
        private List<Pessoa> pessoas;

        public FormPessoa(List<Pessoa> pessoas)
        {
            InitializeComponent();
            this.pessoas = pessoas;
            AssociarDataGridView();
        }

        private void AssociarDataGridView()
        {
            dataGridView1.DataSource = pessoas;
        }

    }
}
