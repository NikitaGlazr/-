namespace Практическая_25_26
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlЕop = new System.Windows.Forms.Panel();
            this.lblMarathon = new System.Windows.Forms.Label();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.lblDateTimeDay = new System.Windows.Forms.Label();
            this.lblTextInformation = new System.Windows.Forms.Label();
            this.btnRoundBMR = new Практическая_25_26.btnRound();
            this.btnRound2BMI = new Практическая_25_26.btnRound();
            this.btnRoundDateDay = new Практическая_25_26.btnRound();
            this.btnRoundInformation = new Практическая_25_26.btnRound();
            this.pnlЕop.SuspendLayout();
            this.pnlDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlЕop
            // 
            this.pnlЕop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlЕop.Controls.Add(this.lblMarathon);
            this.pnlЕop.Location = new System.Drawing.Point(0, 2);
            this.pnlЕop.Name = "pnlЕop";
            this.pnlЕop.Size = new System.Drawing.Size(980, 93);
            this.pnlЕop.TabIndex = 3;
            this.pnlЕop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlЕop_Paint);
            // 
            // lblMarathon
            // 
            this.lblMarathon.AutoSize = true;
            this.lblMarathon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblMarathon.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarathon.Location = new System.Drawing.Point(203, 22);
            this.lblMarathon.Name = "lblMarathon";
            this.lblMarathon.Size = new System.Drawing.Size(444, 39);
            this.lblMarathon.TabIndex = 4;
            this.lblMarathon.Text = "MARATHON SKILLS 2023";
            this.lblMarathon.Click += new System.EventHandler(this.lblMarathon_Click);
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlDown.Controls.Add(this.lblDateTimeDay);
            this.pnlDown.Location = new System.Drawing.Point(2, 475);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(978, 85);
            this.pnlDown.TabIndex = 4;
            this.pnlDown.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDown_Paint);
            // 
            // lblDateTimeDay
            // 
            this.lblDateTimeDay.AutoSize = true;
            this.lblDateTimeDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDateTimeDay.Location = new System.Drawing.Point(172, 35);
            this.lblDateTimeDay.Name = "lblDateTimeDay";
            this.lblDateTimeDay.Size = new System.Drawing.Size(629, 25);
            this.lblDateTimeDay.TabIndex = 0;
            this.lblDateTimeDay.Text = "NN дней NN часов NN мин NN сек: осталось, до начала марафона";
            this.lblDateTimeDay.Click += new System.EventHandler(this.lblDateTimeDay_Click);
            // 
            // lblTextInformation
            // 
            this.lblTextInformation.AutoSize = true;
            this.lblTextInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextInformation.Location = new System.Drawing.Point(204, 112);
            this.lblTextInformation.Name = "lblTextInformation";
            this.lblTextInformation.Size = new System.Drawing.Size(565, 31);
            this.lblTextInformation.TabIndex = 8;
            this.lblTextInformation.Text = "Информация о MARATHON SKILLS 2023";
            this.lblTextInformation.Click += new System.EventHandler(this.lblTextInformation_Click);
            // 
            // btnRoundBMR
            // 
            this.btnRoundBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRoundBMR.Location = new System.Drawing.Point(535, 329);
            this.btnRoundBMR.Name = "btnRoundBMR";
            this.btnRoundBMR.Radius = 50;
            this.btnRoundBMR.Size = new System.Drawing.Size(237, 97);
            this.btnRoundBMR.TabIndex = 7;
            this.btnRoundBMR.Text = "BMR калькулятор";
            this.btnRoundBMR.Click += new System.EventHandler(this.btnRoundBMR_Click);
            // 
            // btnRound2BMI
            // 
            this.btnRound2BMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRound2BMI.Location = new System.Drawing.Point(167, 329);
            this.btnRound2BMI.Name = "btnRound2BMI";
            this.btnRound2BMI.Radius = 50;
            this.btnRound2BMI.Size = new System.Drawing.Size(237, 97);
            this.btnRound2BMI.TabIndex = 6;
            this.btnRound2BMI.Text = "BMI калькулятор";
            this.btnRound2BMI.Click += new System.EventHandler(this.btnRound2BMI_Click);
            // 
            // btnRoundDateDay
            // 
            this.btnRoundDateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRoundDateDay.Location = new System.Drawing.Point(535, 205);
            this.btnRoundDateDay.Name = "btnRoundDateDay";
            this.btnRoundDateDay.Radius = 50;
            this.btnRoundDateDay.Size = new System.Drawing.Size(237, 97);
            this.btnRoundDateDay.TabIndex = 5;
            this.btnRoundDateDay.Text = "Насколько долгий марафон";
            this.btnRoundDateDay.Click += new System.EventHandler(this.btnRoundDateDay_Click);
            // 
            // btnRoundInformation
            // 
            this.btnRoundInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRoundInformation.Location = new System.Drawing.Point(167, 205);
            this.btnRoundInformation.Name = "btnRoundInformation";
            this.btnRoundInformation.Radius = 50;
            this.btnRoundInformation.Size = new System.Drawing.Size(237, 97);
            this.btnRoundInformation.TabIndex = 2;
            this.btnRoundInformation.Text = "MARATHON SKILLS 2023";
            this.btnRoundInformation.Click += new System.EventHandler(this.btnRound1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblTextInformation);
            this.Controls.Add(this.btnRoundBMR);
            this.Controls.Add(this.btnRound2BMI);
            this.Controls.Add(this.btnRoundDateDay);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlЕop);
            this.Controls.Add(this.btnRoundInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MARATHON SKILLS 2023 - Find pot more information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlЕop.ResumeLayout(false);
            this.pnlЕop.PerformLayout();
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Практическая_25_26.btnRound btnRoundInformation;
        private System.Windows.Forms.Panel pnlЕop;
        private System.Windows.Forms.Label lblMarathon;
        private System.Windows.Forms.Panel pnlDown;
        private btnRound btnRoundDateDay;
        private btnRound btnRound2BMI;
        private btnRound btnRoundBMR;
        private System.Windows.Forms.Label lblDateTimeDay;
        private System.Windows.Forms.Label lblTextInformation;
    }
}

