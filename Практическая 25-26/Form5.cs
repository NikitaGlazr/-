﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //==================btnRoundBack================================================================================
        private void btnRoundBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Main = this.Owner as Form1;
        }
        //==================btnRoundBack================================================================================

        //============text DateTimeDay до начала лета==========================================================================
        private void Form5_Load(object sender, EventArgs e)
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

        private void pBAdditionalInformationAboutCalories_Click(object sender, EventArgs e)
        {
            Form7 AddRec = new Form7();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }
        //============text DateTimeDay до начала лета==========================================================================



    }
}
