using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_25_26
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnRoundBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 Main = this.Owner as Form3;
            Form1 Main_dop = this.Owner as Form1;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
