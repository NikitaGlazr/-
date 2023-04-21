using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_25_26
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           
        //============BUTTON==============================================================================================
        private void btnRound1_Click_1(object sender, EventArgs e)
        {
            Form3 AddRec = new Form3();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }
        private void btnRoundBMR_Click(object sender, EventArgs e)
        {
            Form5 AddRec = new Form5();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }
        private void btnRoundDateDay_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }
        private void btnRound2BMI_Click(object sender, EventArgs e)
        {
            Form4 AddRec = new Form4();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }
        //============BUTTON==============================================================================================
       



        //============text DateTimeDay до начала лета==========================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime targetDate = new DateTime(2023, 6, 20, 8, 0, 0); // заданная дата
            TimeSpan remainingTime = targetDate - DateTime.Now; // расчет времени до заданной даты

            string timeLeft = String.Format("{0} дней {1} часов {2} минут {3} секунд: осталось, до начала марафона",
                remainingTime.Days, remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds); // форматирование текста

            lblDateTimeDay.Text = timeLeft; // вывод текста в Label.

            Timer timer = new Timer();
            timer.Interval = 1000; // интервал таймера в сек
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime targetDate = new DateTime(2023, 6, 20, 8, 0, 0); // заданная дата
            TimeSpan remainingTime = targetDate - DateTime.Now; // расчет времени до заданной даты

            string timeLeft = String.Format("{0} дней {1} часов {2} минут {3} секунд: осталось, до начала марафона",
                remainingTime.Days, remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds); // форматирование текста

            lblDateTimeDay.Text = timeLeft; // вывод текста в Label
        }

        private void pnlЕop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMarathon_Click(object sender, EventArgs e)
        {

        }

        private void lblTextInformation_Click(object sender, EventArgs e)
        {

        }

        private void pnlDown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDateTimeDay_Click(object sender, EventArgs e)
        {

        }

        //============text DateTimeDay до начала лета==========================================================================



    }
}
