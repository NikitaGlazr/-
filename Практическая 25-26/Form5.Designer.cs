namespace Практическая_25_26
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pnlЕop = new System.Windows.Forms.Panel();
            this.btnRoundBack = new Практическая_25_26.btnRound();
            this.lblMarathon = new System.Windows.Forms.Label();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.lblDateTimeDay = new System.Windows.Forms.Label();
            this.lblTextInformation = new System.Windows.Forms.Label();
            this.lblInformationBMR = new System.Windows.Forms.Label();
            this.pnlChoiceOf2Genders = new System.Windows.Forms.Panel();
            this.pBGirl = new System.Windows.Forms.PictureBox();
            this.pBMan = new System.Windows.Forms.PictureBox();
            this.lblMan = new System.Windows.Forms.Label();
            this.lblGirl = new System.Windows.Forms.Label();
            this.btnRoundCancel = new Практическая_25_26.btnRound();
            this.btnRoundCalculate = new Практическая_25_26.btnRound();
            this.lblKG = new System.Windows.Forms.Label();
            this.lblCM = new System.Windows.Forms.Label();
            this.tBWeigth = new System.Windows.Forms.TextBox();
            this.tBHeight = new System.Windows.Forms.TextBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblAgeright = new System.Windows.Forms.Label();
            this.tBAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblInformationAboutCalories = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDailyCalories = new System.Windows.Forms.Label();
            this.pBAdditionalInformationAboutCalories = new System.Windows.Forms.PictureBox();
            this.lblSedentary = new System.Windows.Forms.Label();
            this.lblNumberSedentary = new System.Windows.Forms.Label();
            this.lblLittleActivity = new System.Windows.Forms.Label();
            this.lblNumberLittleActivity = new System.Windows.Forms.Label();
            this.lblAverageActivity = new System.Windows.Forms.Label();
            this.lblNumberAverageActivity = new System.Windows.Forms.Label();
            this.lblStrongActivity = new System.Windows.Forms.Label();
            this.lblNumberStrongActivity = new System.Windows.Forms.Label();
            this.lblMaximumActivity = new System.Windows.Forms.Label();
            this.lblNumberMaximumActivity = new System.Windows.Forms.Label();
            this.pnlCalories = new System.Windows.Forms.Panel();
            this.lblYouBMR = new System.Windows.Forms.Label();
            this.pnlЕop.SuspendLayout();
            this.pnlDown.SuspendLayout();
            this.pnlChoiceOf2Genders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBGirl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAdditionalInformationAboutCalories)).BeginInit();
            this.pnlCalories.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlЕop
            // 
            this.pnlЕop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlЕop.Controls.Add(this.btnRoundBack);
            this.pnlЕop.Controls.Add(this.lblMarathon);
            this.pnlЕop.Location = new System.Drawing.Point(1, 0);
            this.pnlЕop.Name = "pnlЕop";
            this.pnlЕop.Size = new System.Drawing.Size(980, 93);
            this.pnlЕop.TabIndex = 6;
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
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlDown.Controls.Add(this.lblDateTimeDay);
            this.pnlDown.Location = new System.Drawing.Point(3, 595);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(978, 85);
            this.pnlDown.TabIndex = 7;
            // 
            // lblDateTimeDay
            // 
            this.lblDateTimeDay.AutoSize = true;
            this.lblDateTimeDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDateTimeDay.Location = new System.Drawing.Point(192, 33);
            this.lblDateTimeDay.Name = "lblDateTimeDay";
            this.lblDateTimeDay.Size = new System.Drawing.Size(629, 25);
            this.lblDateTimeDay.TabIndex = 0;
            this.lblDateTimeDay.Text = "NN дней NN часов NN мин NN сек: осталось, до начала марафона";
            // 
            // lblTextInformation
            // 
            this.lblTextInformation.AutoSize = true;
            this.lblTextInformation.BackColor = System.Drawing.SystemColors.Control;
            this.lblTextInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextInformation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTextInformation.Location = new System.Drawing.Point(375, 107);
            this.lblTextInformation.Name = "lblTextInformation";
            this.lblTextInformation.Size = new System.Drawing.Size(227, 31);
            this.lblTextInformation.TabIndex = 11;
            this.lblTextInformation.Text = "BMI калькулятор";
            // 
            // lblInformationBMR
            // 
            this.lblInformationBMR.AutoSize = true;
            this.lblInformationBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInformationBMR.Location = new System.Drawing.Point(8, 138);
            this.lblInformationBMR.Name = "lblInformationBMR";
            this.lblInformationBMR.Size = new System.Drawing.Size(386, 102);
            this.lblInformationBMR.TabIndex = 13;
            this.lblInformationBMR.Text = resources.GetString("lblInformationBMR.Text");
            // 
            // pnlChoiceOf2Genders
            // 
            this.pnlChoiceOf2Genders.Controls.Add(this.pBGirl);
            this.pnlChoiceOf2Genders.Controls.Add(this.pBMan);
            this.pnlChoiceOf2Genders.Controls.Add(this.lblMan);
            this.pnlChoiceOf2Genders.Controls.Add(this.lblGirl);
            this.pnlChoiceOf2Genders.Location = new System.Drawing.Point(32, 244);
            this.pnlChoiceOf2Genders.Name = "pnlChoiceOf2Genders";
            this.pnlChoiceOf2Genders.Size = new System.Drawing.Size(300, 202);
            this.pnlChoiceOf2Genders.TabIndex = 35;
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
            // btnRoundCancel
            // 
            this.btnRoundCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRoundCancel.Location = new System.Drawing.Point(188, 547);
            this.btnRoundCancel.Name = "btnRoundCancel";
            this.btnRoundCancel.Radius = 10;
            this.btnRoundCancel.Size = new System.Drawing.Size(93, 29);
            this.btnRoundCancel.TabIndex = 34;
            this.btnRoundCancel.Text = "отмена";
            // 
            // btnRoundCalculate
            // 
            this.btnRoundCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRoundCalculate.Location = new System.Drawing.Point(80, 547);
            this.btnRoundCalculate.Name = "btnRoundCalculate";
            this.btnRoundCalculate.Radius = 10;
            this.btnRoundCalculate.Size = new System.Drawing.Size(93, 29);
            this.btnRoundCalculate.TabIndex = 33;
            this.btnRoundCalculate.Text = "Рассчитать";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKG.Location = new System.Drawing.Point(220, 491);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(20, 17);
            this.lblKG.TabIndex = 32;
            this.lblKG.Text = "кг";
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCM.Location = new System.Drawing.Point(218, 459);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(24, 17);
            this.lblCM.TabIndex = 31;
            this.lblCM.Text = "см";
            // 
            // tBWeigth
            // 
            this.tBWeigth.Location = new System.Drawing.Point(156, 491);
            this.tBWeigth.Name = "tBWeigth";
            this.tBWeigth.Size = new System.Drawing.Size(52, 20);
            this.tBWeigth.TabIndex = 30;
            // 
            // tBHeight
            // 
            this.tBHeight.Location = new System.Drawing.Point(156, 457);
            this.tBHeight.Name = "tBHeight";
            this.tBHeight.Size = new System.Drawing.Size(52, 20);
            this.tBHeight.TabIndex = 29;
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblweight.Location = new System.Drawing.Point(91, 491);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(36, 17);
            this.lblweight.TabIndex = 28;
            this.lblweight.Text = "Вес:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHeight.Location = new System.Drawing.Point(91, 460);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(43, 17);
            this.lblHeight.TabIndex = 27;
            this.lblHeight.Text = "Рост:";
            // 
            // lblAgeright
            // 
            this.lblAgeright.AutoSize = true;
            this.lblAgeright.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAgeright.Location = new System.Drawing.Point(219, 521);
            this.lblAgeright.Name = "lblAgeright";
            this.lblAgeright.Size = new System.Drawing.Size(31, 17);
            this.lblAgeright.TabIndex = 38;
            this.lblAgeright.Text = "лет";
            // 
            // tBAge
            // 
            this.tBAge.Location = new System.Drawing.Point(155, 521);
            this.tBAge.Name = "tBAge";
            this.tBAge.Size = new System.Drawing.Size(52, 20);
            this.tBAge.TabIndex = 37;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAge.Location = new System.Drawing.Point(90, 521);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(66, 17);
            this.lblAge.TabIndex = 36;
            this.lblAge.Text = "Возраст:";
            // 
            // lblInformationAboutCalories
            // 
            this.lblInformationAboutCalories.AutoSize = true;
            this.lblInformationAboutCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblInformationAboutCalories.Location = new System.Drawing.Point(572, 160);
            this.lblInformationAboutCalories.Name = "lblInformationAboutCalories";
            this.lblInformationAboutCalories.Size = new System.Drawing.Size(365, 25);
            this.lblInformationAboutCalories.TabIndex = 39;
            this.lblInformationAboutCalories.Text = "Информация о показателях калорий ";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumber.Location = new System.Drawing.Point(185, 47);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(49, 20);
            this.lblNumber.TabIndex = 41;
            this.lblNumber.Text = "1,467";
            // 
            // lblDailyCalories
            // 
            this.lblDailyCalories.AutoSize = true;
            this.lblDailyCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDailyCalories.Location = new System.Drawing.Point(61, 98);
            this.lblDailyCalories.Name = "lblDailyCalories";
            this.lblDailyCalories.Size = new System.Drawing.Size(242, 20);
            this.lblDailyCalories.TabIndex = 42;
            this.lblDailyCalories.Text = "Ежедневно тратится калорий ";
            // 
            // pBAdditionalInformationAboutCalories
            // 
            this.pBAdditionalInformationAboutCalories.Image = ((System.Drawing.Image)(resources.GetObject("pBAdditionalInformationAboutCalories.Image")));
            this.pBAdditionalInformationAboutCalories.Location = new System.Drawing.Point(309, 98);
            this.pBAdditionalInformationAboutCalories.Name = "pBAdditionalInformationAboutCalories";
            this.pBAdditionalInformationAboutCalories.Size = new System.Drawing.Size(30, 30);
            this.pBAdditionalInformationAboutCalories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBAdditionalInformationAboutCalories.TabIndex = 43;
            this.pBAdditionalInformationAboutCalories.TabStop = false;
            this.pBAdditionalInformationAboutCalories.Click += new System.EventHandler(this.pBAdditionalInformationAboutCalories_Click);
            // 
            // lblSedentary
            // 
            this.lblSedentary.AutoSize = true;
            this.lblSedentary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSedentary.Location = new System.Drawing.Point(169, 150);
            this.lblSedentary.Name = "lblSedentary";
            this.lblSedentary.Size = new System.Drawing.Size(80, 20);
            this.lblSedentary.TabIndex = 44;
            this.lblSedentary.Text = "Сидячий:";
            // 
            // lblNumberSedentary
            // 
            this.lblNumberSedentary.AutoSize = true;
            this.lblNumberSedentary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberSedentary.Location = new System.Drawing.Point(255, 150);
            this.lblNumberSedentary.Name = "lblNumberSedentary";
            this.lblNumberSedentary.Size = new System.Drawing.Size(49, 20);
            this.lblNumberSedentary.TabIndex = 45;
            this.lblNumberSedentary.Text = "2,004";
            // 
            // lblLittleActivity
            // 
            this.lblLittleActivity.AutoSize = true;
            this.lblLittleActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLittleActivity.Location = new System.Drawing.Point(61, 188);
            this.lblLittleActivity.Name = "lblLittleActivity";
            this.lblLittleActivity.Size = new System.Drawing.Size(194, 20);
            this.lblLittleActivity.TabIndex = 46;
            this.lblLittleActivity.Text = "Маленькая активность: ";
            // 
            // lblNumberLittleActivity
            // 
            this.lblNumberLittleActivity.AutoSize = true;
            this.lblNumberLittleActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberLittleActivity.Location = new System.Drawing.Point(255, 188);
            this.lblNumberLittleActivity.Name = "lblNumberLittleActivity";
            this.lblNumberLittleActivity.Size = new System.Drawing.Size(49, 20);
            this.lblNumberLittleActivity.TabIndex = 47;
            this.lblNumberLittleActivity.Text = "2,296";
            // 
            // lblAverageActivity
            // 
            this.lblAverageActivity.AutoSize = true;
            this.lblAverageActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAverageActivity.Location = new System.Drawing.Point(77, 235);
            this.lblAverageActivity.Name = "lblAverageActivity";
            this.lblAverageActivity.Size = new System.Drawing.Size(172, 20);
            this.lblAverageActivity.TabIndex = 48;
            this.lblAverageActivity.Text = "Средняя активность:";
            // 
            // lblNumberAverageActivity
            // 
            this.lblNumberAverageActivity.AutoSize = true;
            this.lblNumberAverageActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberAverageActivity.Location = new System.Drawing.Point(255, 235);
            this.lblNumberAverageActivity.Name = "lblNumberAverageActivity";
            this.lblNumberAverageActivity.Size = new System.Drawing.Size(49, 20);
            this.lblNumberAverageActivity.TabIndex = 49;
            this.lblNumberAverageActivity.Text = "2,589";
            // 
            // lblStrongActivity
            // 
            this.lblStrongActivity.AutoSize = true;
            this.lblStrongActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStrongActivity.Location = new System.Drawing.Point(78, 272);
            this.lblStrongActivity.Name = "lblStrongActivity";
            this.lblStrongActivity.Size = new System.Drawing.Size(171, 20);
            this.lblStrongActivity.TabIndex = 50;
            this.lblStrongActivity.Text = "Сильная активность:";
            // 
            // lblNumberStrongActivity
            // 
            this.lblNumberStrongActivity.AutoSize = true;
            this.lblNumberStrongActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberStrongActivity.Location = new System.Drawing.Point(255, 272);
            this.lblNumberStrongActivity.Name = "lblNumberStrongActivity";
            this.lblNumberStrongActivity.Size = new System.Drawing.Size(49, 20);
            this.lblNumberStrongActivity.TabIndex = 51;
            this.lblNumberStrongActivity.Text = "2,881";
            // 
            // lblMaximumActivity
            // 
            this.lblMaximumActivity.AutoSize = true;
            this.lblMaximumActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMaximumActivity.Location = new System.Drawing.Point(32, 310);
            this.lblMaximumActivity.Name = "lblMaximumActivity";
            this.lblMaximumActivity.Size = new System.Drawing.Size(218, 20);
            this.lblMaximumActivity.TabIndex = 52;
            this.lblMaximumActivity.Text = "Максимальная активность:";
            // 
            // lblNumberMaximumActivity
            // 
            this.lblNumberMaximumActivity.AutoSize = true;
            this.lblNumberMaximumActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumberMaximumActivity.Location = new System.Drawing.Point(255, 310);
            this.lblNumberMaximumActivity.Name = "lblNumberMaximumActivity";
            this.lblNumberMaximumActivity.Size = new System.Drawing.Size(49, 20);
            this.lblNumberMaximumActivity.TabIndex = 53;
            this.lblNumberMaximumActivity.Text = "3,173";
            // 
            // pnlCalories
            // 
            this.pnlCalories.Controls.Add(this.lblYouBMR);
            this.pnlCalories.Controls.Add(this.lblNumberMaximumActivity);
            this.pnlCalories.Controls.Add(this.lblMaximumActivity);
            this.pnlCalories.Controls.Add(this.lblNumberStrongActivity);
            this.pnlCalories.Controls.Add(this.lblStrongActivity);
            this.pnlCalories.Controls.Add(this.lblNumberAverageActivity);
            this.pnlCalories.Controls.Add(this.lblAverageActivity);
            this.pnlCalories.Controls.Add(this.lblNumberLittleActivity);
            this.pnlCalories.Controls.Add(this.lblLittleActivity);
            this.pnlCalories.Controls.Add(this.lblNumberSedentary);
            this.pnlCalories.Controls.Add(this.lblSedentary);
            this.pnlCalories.Controls.Add(this.pBAdditionalInformationAboutCalories);
            this.pnlCalories.Controls.Add(this.lblDailyCalories);
            this.pnlCalories.Controls.Add(this.lblNumber);
            this.pnlCalories.Location = new System.Drawing.Point(546, 188);
            this.pnlCalories.Name = "pnlCalories";
            this.pnlCalories.Size = new System.Drawing.Size(412, 387);
            this.pnlCalories.TabIndex = 54;
            // 
            // lblYouBMR
            // 
            this.lblYouBMR.AutoSize = true;
            this.lblYouBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblYouBMR.Location = new System.Drawing.Point(168, 12);
            this.lblYouBMR.Name = "lblYouBMR";
            this.lblYouBMR.Size = new System.Drawing.Size(82, 20);
            this.lblYouBMR.TabIndex = 54;
            this.lblYouBMR.Text = "Ваш BMR";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.pnlCalories);
            this.Controls.Add(this.lblInformationAboutCalories);
            this.Controls.Add(this.lblAgeright);
            this.Controls.Add(this.tBAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.pnlChoiceOf2Genders);
            this.Controls.Add(this.btnRoundCancel);
            this.Controls.Add(this.btnRoundCalculate);
            this.Controls.Add(this.lblKG);
            this.Controls.Add(this.lblCM);
            this.Controls.Add(this.tBWeigth);
            this.Controls.Add(this.tBHeight);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblInformationBMR);
            this.Controls.Add(this.lblTextInformation);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlЕop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "MARATHON SKILLS 2023 - BMR calculator";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.pnlЕop.ResumeLayout(false);
            this.pnlЕop.PerformLayout();
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            this.pnlChoiceOf2Genders.ResumeLayout(false);
            this.pnlChoiceOf2Genders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBGirl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAdditionalInformationAboutCalories)).EndInit();
            this.pnlCalories.ResumeLayout(false);
            this.pnlCalories.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlЕop;
        private btnRound btnRoundBack;
        private System.Windows.Forms.Label lblMarathon;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Label lblDateTimeDay;
        private System.Windows.Forms.Label lblTextInformation;
        private System.Windows.Forms.Label lblInformationBMR;
        private System.Windows.Forms.Panel pnlChoiceOf2Genders;
        private System.Windows.Forms.PictureBox pBGirl;
        private System.Windows.Forms.PictureBox pBMan;
        private System.Windows.Forms.Label lblMan;
        private System.Windows.Forms.Label lblGirl;
        private btnRound btnRoundCancel;
        private btnRound btnRoundCalculate;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.TextBox tBWeigth;
        private System.Windows.Forms.TextBox tBHeight;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblAgeright;
        private System.Windows.Forms.TextBox tBAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblInformationAboutCalories;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDailyCalories;
        private System.Windows.Forms.PictureBox pBAdditionalInformationAboutCalories;
        private System.Windows.Forms.Label lblSedentary;
        private System.Windows.Forms.Label lblNumberSedentary;
        private System.Windows.Forms.Label lblLittleActivity;
        private System.Windows.Forms.Label lblNumberLittleActivity;
        private System.Windows.Forms.Label lblAverageActivity;
        private System.Windows.Forms.Label lblNumberAverageActivity;
        private System.Windows.Forms.Label lblStrongActivity;
        private System.Windows.Forms.Label lblNumberStrongActivity;
        private System.Windows.Forms.Label lblMaximumActivity;
        private System.Windows.Forms.Label lblNumberMaximumActivity;
        private System.Windows.Forms.Panel pnlCalories;
        private System.Windows.Forms.Label lblYouBMR;
    }
}