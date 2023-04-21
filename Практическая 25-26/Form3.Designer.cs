namespace Практическая_25_26
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pnlЕop = new System.Windows.Forms.Panel();
            this.btnRoundBack = new Практическая_25_26.btnRound();
            this.lblMarathon = new System.Windows.Forms.Label();
            this.lblTextInformation = new System.Windows.Forms.Label();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.lblDateTimeDay = new System.Windows.Forms.Label();
            this.lblMarathonInformation = new System.Windows.Forms.Label();
            this.pBMap = new System.Windows.Forms.PictureBox();
            this.lblMap = new System.Windows.Forms.Label();
            this.pBBanco = new System.Windows.Forms.PictureBox();
            this.pBIbirapuera = new System.Windows.Forms.PictureBox();
            this.pBTeatroMunicipal = new System.Windows.Forms.PictureBox();
            this.pBMarathonImage = new System.Windows.Forms.PictureBox();
            this.pnlЕop.SuspendLayout();
            this.pnlDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIbirapuera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTeatroMunicipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMarathonImage)).BeginInit();
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
            this.pnlЕop.TabIndex = 4;
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
            this.lblTextInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextInformation.Location = new System.Drawing.Point(210, 101);
            this.lblTextInformation.Name = "lblTextInformation";
            this.lblTextInformation.Size = new System.Drawing.Size(565, 31);
            this.lblTextInformation.TabIndex = 9;
            this.lblTextInformation.Text = "Информация о MARATHON SKILLS 2023";
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlDown.Controls.Add(this.lblDateTimeDay);
            this.pnlDown.Location = new System.Drawing.Point(3, 594);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(978, 85);
            this.pnlDown.TabIndex = 10;
            // 
            // lblDateTimeDay
            // 
            this.lblDateTimeDay.AutoSize = true;
            this.lblDateTimeDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDateTimeDay.Location = new System.Drawing.Point(189, 31);
            this.lblDateTimeDay.Name = "lblDateTimeDay";
            this.lblDateTimeDay.Size = new System.Drawing.Size(629, 25);
            this.lblDateTimeDay.TabIndex = 0;
            this.lblDateTimeDay.Text = "NN дней NN часов NN мин NN сек: осталось, до начала марафона";
            // 
            // lblMarathonInformation
            // 
            this.lblMarathonInformation.AutoSize = true;
            this.lblMarathonInformation.Location = new System.Drawing.Point(454, 141);
            this.lblMarathonInformation.Name = "lblMarathonInformation";
            this.lblMarathonInformation.Size = new System.Drawing.Size(515, 442);
            this.lblMarathonInformation.TabIndex = 11;
            this.lblMarathonInformation.Text = resources.GetString("lblMarathonInformation.Text");
            // 
            // pBMap
            // 
            this.pBMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBMap.ErrorImage = null;
            this.pBMap.Image = ((System.Drawing.Image)(resources.GetObject("pBMap.Image")));
            this.pBMap.InitialImage = null;
            this.pBMap.Location = new System.Drawing.Point(41, 155);
            this.pBMap.Name = "pBMap";
            this.pBMap.Size = new System.Drawing.Size(340, 157);
            this.pBMap.TabIndex = 12;
            this.pBMap.TabStop = false;
            this.pBMap.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(129, 314);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(172, 26);
            this.lblMap.TabIndex = 13;
            this.lblMap.Text = "            Карта марафона \r\n(Нажмите, чтобы открыть карту)";
            // 
            // pBBanco
            // 
            this.pBBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBBanco.Image = ((System.Drawing.Image)(resources.GetObject("pBBanco.Image")));
            this.pBBanco.Location = new System.Drawing.Point(67, 359);
            this.pBBanco.Name = "pBBanco";
            this.pBBanco.Size = new System.Drawing.Size(76, 104);
            this.pBBanco.TabIndex = 14;
            this.pBBanco.TabStop = false;
            // 
            // pBIbirapuera
            // 
            this.pBIbirapuera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBIbirapuera.Image = ((System.Drawing.Image)(resources.GetObject("pBIbirapuera.Image")));
            this.pBIbirapuera.Location = new System.Drawing.Point(226, 469);
            this.pBIbirapuera.Name = "pBIbirapuera";
            this.pBIbirapuera.Size = new System.Drawing.Size(171, 104);
            this.pBIbirapuera.TabIndex = 15;
            this.pBIbirapuera.TabStop = false;
            // 
            // pBTeatroMunicipal
            // 
            this.pBTeatroMunicipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBTeatroMunicipal.Image = ((System.Drawing.Image)(resources.GetObject("pBTeatroMunicipal.Image")));
            this.pBTeatroMunicipal.Location = new System.Drawing.Point(24, 469);
            this.pBTeatroMunicipal.Name = "pBTeatroMunicipal";
            this.pBTeatroMunicipal.Size = new System.Drawing.Size(156, 104);
            this.pBTeatroMunicipal.TabIndex = 16;
            this.pBTeatroMunicipal.TabStop = false;
            // 
            // pBMarathonImage
            // 
            this.pBMarathonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBMarathonImage.Image = ((System.Drawing.Image)(resources.GetObject("pBMarathonImage.Image")));
            this.pBMarathonImage.Location = new System.Drawing.Point(235, 359);
            this.pBMarathonImage.Name = "pBMarathonImage";
            this.pBMarathonImage.Size = new System.Drawing.Size(155, 104);
            this.pBMarathonImage.TabIndex = 17;
            this.pBMarathonImage.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.pBMarathonImage);
            this.Controls.Add(this.pBTeatroMunicipal);
            this.Controls.Add(this.pBIbirapuera);
            this.Controls.Add(this.pBBanco);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.pBMap);
            this.Controls.Add(this.lblMarathonInformation);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.lblTextInformation);
            this.Controls.Add(this.pnlЕop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "MARATHON SKILLS 2023 - About Marathon Skills 2023";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlЕop.ResumeLayout(false);
            this.pnlЕop.PerformLayout();
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBIbirapuera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTeatroMunicipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMarathonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlЕop;
        private System.Windows.Forms.Label lblMarathon;
        private System.Windows.Forms.Label lblTextInformation;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Label lblDateTimeDay;
        private btnRound btnRoundBack;
        private System.Windows.Forms.Label lblMarathonInformation;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.PictureBox pBMap;
        private System.Windows.Forms.PictureBox pBBanco;
        private System.Windows.Forms.PictureBox pBIbirapuera;
        private System.Windows.Forms.PictureBox pBTeatroMunicipal;
        private System.Windows.Forms.PictureBox pBMarathonImage;
    }
}