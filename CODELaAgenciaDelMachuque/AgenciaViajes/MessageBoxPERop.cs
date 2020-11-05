using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes
{
    public partial class MessageBoxPERop : Form
    {
        public MessageBoxPERop()
        {
            InitializeComponent();
        }
        internal string OP;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(cbOPs.SelectedItem != null)
            {
                OP = cbOPs.Text;
                Dispose();
            }
        }
    }
}
