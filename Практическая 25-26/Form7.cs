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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Form5 Main = this.Owner as Form5;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "активностиDataSet.Активность". При необходимости она может быть перемещена или удалена.
            this.активностьTableAdapter.Fill(this.активностиDataSet.Активность);

        }
    }
}
