namespace Практическая_25_26
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.lbllevels = new System.Windows.Forms.Label();
            this.lblDescriptionLevels = new System.Windows.Forms.Label();
            this.DGWDescriptionOfActivities = new System.Windows.Forms.DataGridView();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.активностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.активностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.активностиDataSet = new Практическая_25_26.АктивностиDataSet();
            this.активностьTableAdapter = new Практическая_25_26.АктивностиDataSetTableAdapters.АктивностьTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGWDescriptionOfActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.активностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.активностиDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllevels
            // 
            this.lbllevels.AutoSize = true;
            this.lbllevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbllevels.Location = new System.Drawing.Point(439, 18);
            this.lbllevels.Name = "lbllevels";
            this.lbllevels.Size = new System.Drawing.Size(191, 25);
            this.lbllevels.TabIndex = 0;
            this.lbllevels.Text = "Уровни активности";
            // 
            // lblDescriptionLevels
            // 
            this.lblDescriptionLevels.AutoSize = true;
            this.lblDescriptionLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDescriptionLevels.Location = new System.Drawing.Point(28, 73);
            this.lblDescriptionLevels.Name = "lblDescriptionLevels";
            this.lblDescriptionLevels.Size = new System.Drawing.Size(299, 25);
            this.lblDescriptionLevels.TabIndex = 1;
            this.lblDescriptionLevels.Text = "Описание уровней активности ";
            // 
            // DGWDescriptionOfActivities
            // 
            this.DGWDescriptionOfActivities.AllowUserToAddRows = false;
            this.DGWDescriptionOfActivities.AllowUserToDeleteRows = false;
            this.DGWDescriptionOfActivities.AutoGenerateColumns = false;
            this.DGWDescriptionOfActivities.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGWDescriptionOfActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWDescriptionOfActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.типDataGridViewTextBoxColumn,
            this.активностьDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
            this.DGWDescriptionOfActivities.DataSource = this.активностьBindingSource;
            this.DGWDescriptionOfActivities.Location = new System.Drawing.Point(33, 116);
            this.DGWDescriptionOfActivities.Name = "DGWDescriptionOfActivities";
            this.DGWDescriptionOfActivities.ReadOnly = true;
            this.DGWDescriptionOfActivities.Size = new System.Drawing.Size(1046, 322);
            this.DGWDescriptionOfActivities.TabIndex = 2;
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            this.типDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // активностьDataGridViewTextBoxColumn
            // 
            this.активностьDataGridViewTextBoxColumn.DataPropertyName = "Активность";
            this.активностьDataGridViewTextBoxColumn.HeaderText = "Активность";
            this.активностьDataGridViewTextBoxColumn.Name = "активностьDataGridViewTextBoxColumn";
            this.активностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "\tОписание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "\tОписание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // активностьBindingSource
            // 
            this.активностьBindingSource.DataMember = "Активность";
            this.активностьBindingSource.DataSource = this.активностиDataSet;
            // 
            // активностиDataSet
            // 
            this.активностиDataSet.DataSetName = "АктивностиDataSet";
            this.активностиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // активностьTableAdapter
            // 
            this.активностьTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 468);
            this.Controls.Add(this.DGWDescriptionOfActivities);
            this.Controls.Add(this.lblDescriptionLevels);
            this.Controls.Add(this.lbllevels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Description of activity levels";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWDescriptionOfActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.активностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.активностиDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllevels;
        private System.Windows.Forms.Label lblDescriptionLevels;
        private System.Windows.Forms.DataGridView DGWDescriptionOfActivities;
        private АктивностиDataSet активностиDataSet;
        private System.Windows.Forms.BindingSource активностьBindingSource;
        private АктивностиDataSetTableAdapters.АктивностьTableAdapter активностьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn активностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
    }
}