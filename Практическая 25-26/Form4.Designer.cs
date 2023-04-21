namespace Практическая_25_26
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pnlЕop = new System.Windows.Forms.Panel();
            this.btnRoundBack = new Практическая_25_26.btnRound();
            this.lblMarathon = new System.Windows.Forms.Label();
            this.lblTextInformation = new System.Windows.Forms.Label();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.lblDateTimeDay = new System.Windows.Forms.Label();
            this.lblInformationBMI = new System.Windows.Forms.Label();
            this.pBMan = new System.Windows.Forms.PictureBox();
            this.pBGirl = new System.Windows.Forms.PictureBox();
            this.lblMan = new System.Windows.Forms.Label();
            this.lblGirl = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.tBHeight = new System.Windows.Forms.TextBox();
            this.tBweigth = new System.Windows.Forms.TextBox();
            this.lblCM = new System.Windows.Forms.Label();
            this.lblKG = new System.Windows.Forms.Label();
            this.btnRoundCalculate = new Практическая_25_26.btnRound();
            this.btnRoundCancel = new Практическая_25_26.btnRound();
            this.pblManOrGirl = new System.Windows.Forms.Panel();
            this.lblHealthy = new System.Windows.Forms.Label();
            this.pBManOrGirl = new System.Windows.Forms.PictureBox();
            this.pnlChoiceOf2Genders = new System.Windows.Forms.Panel();
            this.tBWeight = new System.Windows.Forms.TrackBar();
            this.lblInadequate = new System.Windows.Forms.Label();
            this.lblHealthytb = new System.Windows.Forms.Label();
            this.lblExcess = new System.Windows.Forms.Label();
            this.lblObesity = new System.Windows.Forms.Label();
            this.pnlЕop.SuspendLayout();
            this.pnlDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGirl)).BeginInit();
            this.pblManOrGirl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBManOrGirl)).BeginInit();
            this.pnlChoiceOf2Genders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlЕop
            // 
            this.pnlЕop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlЕop.Controls.Add(this.btnRoundBack);
            this.pnlЕop.Controls.Add(this.lblMarathon);
            this.pnlЕop.Location = new System.Drawing.Point(2, 1);
            this.pnlЕop.Name = "pnlЕop";
            this.pnlЕop.Size = new System.Drawing.Size(980, 93);
            this.pnlЕop.TabIndex = 5;
            // 
            // btnRoundBack
            // 
            this.btnRoundBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRoundBack.Location = new System.Drawing.Point(10, 22);
            this.btnRoundBack.Name = "btnRoundBack";
            this.btnRoundBack.Radius = 10;
            this.btnRoundBack.Size = new System.Drawing.Size(111, 39);
            this.btnRoundBack.TabIndex = 6;
            this.btnRoundBack.Text = "Назад";
            this.btnRoundBack.Click += new System.EventHandler(this.btnRoundBack_Click);
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
            // 
            // lblTextInformation
            // 
            this.lblTextInformation.AutoSize = true;
            this.lblTextInformation.BackColor = System.Drawing.SystemColors.Control;
            this.lblTextInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextInformation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTextInformation.Location = new System.Drawing.Point(372, 109);
            this.lblTextInformation.Name = "lblTextInformation";
            this.lblTextInformation.Size = new System.Drawing.Size(227, 31);
            this.lblTextInformation.TabIndex = 10;
            this.lblTextInformation.Text = "BMI калькулятор";
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlDown.Controls.Add(this.lblDateTimeDay);
            this.pnlDown.Location = new System.Drawing.Point(2, 595);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(978, 85);
            this.pnlDown.TabIndex = 11;
            // 
            // lblDateTimeDay
            // 
            this.lblDateTimeDay.AutoSize = true;
            this.lblDateTimeDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDateTimeDay.Location = new System.Drawing.Point(175, 31);
            this.lblDateTimeDay.Name = "lblDateTimeDay";
            this.lblDateTimeDay.Size = new System.Drawing.Size(629, 25);
            this.lblDateTimeDay.TabIndex = 0;
            this.lblDateTimeDay.Text = "NN дней NN часов NN мин NN сек: осталось, до начала марафона";
            // 
            // lblInformationBMI
            // 
            this.lblInformationBMI.AutoSize = true;
            this.lblInformationBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInformationBMI.Location = new System.Drawing.Point(12, 140);
            this.lblInformationBMI.Name = "lblInformationBMI";
            this.lblInformationBMI.Size = new System.Drawing.Size(476, 102);
            this.lblInformationBMI.TabIndex = 12;
            this.lblInformationBMI.Text = resources.GetString("lblInformationBMI.Text");
            // 
            // pBMan
            // 
            this.pBMan.Image = ((System.Drawing.Image)(resources.GetObject("pBMan.Image")));
            this.pBMan.Location = new System.Drawing.Point(15, 17);
            this.pBMan.Name = "pBMan";
            this.pBMan.Size = new System.Drawing.Size(118, 154);
            this.pBMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBMan.TabIndex = 13;
            this.pBMan.TabStop = false;
            this.pBMan.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pBGirl
            // 
            this.pBGirl.Image = ((System.Drawing.Image)(resources.GetObject("pBGirl.Image")));
            this.pBGirl.Location = new System.Drawing.Point(165, 17);
            this.pBGirl.Name = "pBGirl";
            this.pBGirl.Size = new System.Drawing.Size(118, 154);
            this.pBGirl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBGirl.TabIndex = 14;
            this.pBGirl.TabStop = false;
            this.pBGirl.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblMan
            // 
            this.lblMan.AutoSize = true;
            this.lblMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMan.Location = new System.Drawing.Point(38, 179);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(67, 17);
            this.lblMan.TabIndex = 15;
            this.lblMan.Text = "Мужчина";
            // 
            // lblGirl
            // 
            this.lblGirl.AutoSize = true;
            this.lblGirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGirl.Location = new System.Drawing.Point(188, 179);
            this.lblGirl.Name = "lblGirl";
            this.lblGirl.Size = new System.Drawing.Size(72, 17);
            this.lblGirl.TabIndex = 16;
            this.lblGirl.Text = "Женщина";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHeight.Location = new System.Drawing.Point(112, 477);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(43, 17);
            this.lblHeight.TabIndex = 17;
            this.lblHeight.Text = "Рост:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWeight.Location = new System.Drawing.Point(111, 509);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(36, 17);
            this.lblWeight.TabIndex = 18;
            this.lblWeight.Text = "Вес:";
            // 
            // tBHeight
            // 
            this.tBHeight.Location = new System.Drawing.Point(165, 475);
            this.tBHeight.Name = "tBHeight";
            this.tBHeight.Size = new System.Drawing.Size(52, 20);
            this.tBHeight.TabIndex = 19;
            // 
            // tBweigth
            // 
            this.tBweigth.Location = new System.Drawing.Point(165, 509);
            this.tBweigth.Name = "tBweigth";
            this.tBweigth.Size = new System.Drawing.Size(52, 20);
            this.tBweigth.TabIndex = 20;
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCM.Location = new System.Drawing.Point(227, 477);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(24, 17);
            this.lblCM.TabIndex = 21;
            this.lblCM.Text = "см";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKG.Location = new System.Drawing.Point(229, 509);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(20, 17);
            this.lblKG.TabIndex = 22;
            this.lblKG.Text = "кг";
            // 
            // btnRoundCalculate
            // 
            this.btnRoundCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRoundCalculate.Location = new System.Drawing.Point(89, 548);
            this.btnRoundCalculate.Name = "btnRoundCalculate";
            this.btnRoundCalculate.Radius = 10;
            this.btnRoundCalculate.Size = new System.Drawing.Size(93, 29);
            this.btnRoundCalculate.TabIndex = 23;
            this.btnRoundCalculate.Text = "Рассчитать";
            // 
            // btnRoundCancel
            // 
            this.btnRoundCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRoundCancel.Location = new System.Drawing.Point(197, 548);
            this.btnRoundCancel.Name = "btnRoundCancel";
            this.btnRoundCancel.Radius = 10;
            this.btnRoundCancel.Size = new System.Drawing.Size(93, 29);
            this.btnRoundCancel.TabIndex = 24;
            this.btnRoundCancel.Text = "отмена";
            // 
            // pblManOrGirl
            // 
            this.pblManOrGirl.Controls.Add(this.lblHealthy);
            this.pblManOrGirl.Controls.Add(this.pBManOrGirl);
            this.pblManOrGirl.Location = new System.Drawing.Point(625, 166);
            this.pblManOrGirl.Name = "pblManOrGirl";
            this.pblManOrGirl.Size = new System.Drawing.Size(223, 250);
            this.pblManOrGirl.TabIndex = 25;
            // 
            // lblHealthy
            // 
            this.lblHealthy.AutoSize = true;
            this.lblHealthy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHealthy.Location = new System.Drawing.Point(74, 200);
            this.lblHealthy.Name = "lblHealthy";
            this.lblHealthy.Size = new System.Drawing.Size(74, 17);
            this.lblHealthy.TabIndex = 1;
            this.lblHealthy.Text = "Здоровый";
            // 
            // pBManOrGirl
            // 
            this.pBManOrGirl.Image = ((System.Drawing.Image)(resources.GetObject("pBManOrGirl.Image")));
            this.pBManOrGirl.Location = new System.Drawing.Point(35, 23);
            this.pBManOrGirl.Name = "pBManOrGirl";
            this.pBManOrGirl.Size = new System.Drawing.Size(155, 174);
            this.pBManOrGirl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBManOrGirl.TabIndex = 0;
            this.pBManOrGirl.TabStop = false;
            // 
            // pnlChoiceOf2Genders
            // 
            this.pnlChoiceOf2Genders.Controls.Add(this.pBGirl);
            this.pnlChoiceOf2Genders.Controls.Add(this.pBMan);
            this.pnlChoiceOf2Genders.Controls.Add(this.lblMan);
            this.pnlChoiceOf2Genders.Controls.Add(this.lblGirl);
            this.pnlChoiceOf2Genders.Location = new System.Drawing.Point(41, 245);
            this.pnlChoiceOf2Genders.Name = "pnlChoiceOf2Genders";
            this.pnlChoiceOf2Genders.Size = new System.Drawing.Size(300, 215);
            this.pnlChoiceOf2Genders.TabIndex = 26;
            // 
            // tBWeight
            // 
            this.tBWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tBWeight.Location = new System.Drawing.Point(561, 482);
            this.tBWeight.Name = "tBWeight";
            this.tBWeight.Size = new System.Drawing.Size(355, 45);
            this.tBWeight.TabIndex = 27;
            // 
            // lblInadequate
            // 
            this.lblInadequate.AutoSize = true;
            this.lblInadequate.Location = new System.Drawing.Point(569, 539);
            this.lblInadequate.Name = "lblInadequate";
            this.lblInadequate.Size = new System.Drawing.Size(86, 13);
            this.lblInadequate.TabIndex = 28;
            this.lblInadequate.Text = "Недостаточный";
            // 
            // lblHealthytb
            // 
            this.lblHealthytb.AutoSize = true;
            this.lblHealthytb.Location = new System.Drawing.Point(676, 539);
            this.lblHealthytb.Name = "lblHealthytb";
            this.lblHealthytb.Size = new System.Drawing.Size(58, 13);
            this.lblHealthytb.TabIndex = 29;
            this.lblHealthytb.Text = "Здоровый";
            // 
            // lblExcess
            // 
            this.lblExcess.AutoSize = true;
            this.lblExcess.Location = new System.Drawing.Point(761, 539);
            this.lblExcess.Name = "lblExcess";
            this.lblExcess.Size = new System.Drawing.Size(71, 13);
            this.lblExcess.TabIndex = 30;
            this.lblExcess.Text = "Избыточный";
            // 
            // lblObesity
            // 
            this.lblObesity.AutoSize = true;
            this.lblObesity.Location = new System.Drawing.Point(852, 539);
            this.lblObesity.Name = "lblObesity";
            this.lblObesity.Size = new System.Drawing.Size(59, 13);
            this.lblObesity.TabIndex = 31;
            this.lblObesity.Text = "Ожирение";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.lblObesity);
            this.Controls.Add(this.lblExcess);
            this.Controls.Add(this.lblHealthytb);
            this.Controls.Add(this.lblInadequate);
            this.Controls.Add(this.tBWeight);
            this.Controls.Add(this.pnlChoiceOf2Genders);
            this.Controls.Add(this.pblManOrGirl);
            this.Controls.Add(this.btnRoundCancel);
            this.Controls.Add(this.btnRoundCalculate);
            this.Controls.Add(this.lblKG);
            this.Controls.Add(this.lblCM);
            this.Controls.Add(this.tBweigth);
            this.Controls.Add(this.tBHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblInformationBMI);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.lblTextInformation);
            this.Controls.Add(this.pnlЕop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "MARATHON SKILLS 2023 - BMI calculator";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.pnlЕop.ResumeLayout(false);
            this.pnlЕop.PerformLayout();
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBGirl)).EndInit();
            this.pblManOrGirl.ResumeLayout(false);
            this.pblManOrGirl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBManOrGirl)).EndInit();
            this.pnlChoiceOf2Genders.ResumeLayout(false);
            this.pnlChoiceOf2Genders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlЕop;
        private btnRound btnRoundBack;
        private System.Windows.Forms.Label lblMarathon;
        private System.Windows.Forms.Label lblTextInformation;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Label lblDateTimeDay;
        private System.Windows.Forms.Label lblInformationBMI;
        private System.Windows.Forms.PictureBox pBMan;
        private System.Windows.Forms.PictureBox pBGirl;
        private System.Windows.Forms.Label lblMan;
        private System.Windows.Forms.Label lblGirl;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox tBHeight;
        private System.Windows.Forms.TextBox tBweigth;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Label lblKG;
        private btnRound btnRoundCalculate;
        private btnRound btnRoundCancel;
        private System.Windows.Forms.Panel pblManOrGirl;
        private System.Windows.Forms.Label lblHealthy;
        private System.Windows.Forms.PictureBox pBManOrGirl;
        private System.Windows.Forms.Panel pnlChoiceOf2Genders;
        private System.Windows.Forms.TrackBar tBWeight;
        private System.Windows.Forms.Label lblInadequate;
        private System.Windows.Forms.Label lblHealthytb;
        private System.Windows.Forms.Label lblExcess;
        private System.Windows.Forms.Label lblObesity;
    }
}