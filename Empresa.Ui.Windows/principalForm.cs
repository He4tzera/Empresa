using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.Ui.Windows
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }

        private void arquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            incluirCliente f = new incluirCliente();
            f.ShowDialog();
        }
    }
}
