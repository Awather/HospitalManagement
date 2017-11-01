using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class CompSaysNo : Form
    {
        public CompSaysNo()
        {
            InitializeComponent();
        }

        private void pnlOk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
