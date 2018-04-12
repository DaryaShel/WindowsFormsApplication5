namespace WindowsFormsApplication5
{
    partial class FormIndications
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sFUDataSet12 = new WindowsFormsApplication5.SFUDataSet12();
            this.buildingcounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.building_counterTableAdapter = new WindowsFormsApplication5.SFUDataSet12TableAdapters.Building_counterTableAdapter();
            this.зданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодсчетчикаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ресурсDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодсчетчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ресурсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коплатеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topaycounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sFUDataSet11 = new WindowsFormsApplication5.SFUDataSet11();
            this.to_pay_counterTableAdapter = new WindowsFormsApplication5.SFUDataSet11TableAdapters.To_pay_counterTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingcounterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topaycounterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодсчетчикаDataGridViewTextBoxColumn,
            this.ресурсDataGridViewTextBoxColumn,
            this.коплатеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.topaycounterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.зданиеDataGridViewTextBoxColumn,
            this.кодсчетчикаDataGridViewTextBoxColumn1,
            this.ресурсDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.buildingcounterBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(428, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(340, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // sFUDataSet12
            // 
            this.sFUDataSet12.DataSetName = "SFUDataSet12";
            this.sFUDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildingcounterBindingSource
            // 
            this.buildingcounterBindingSource.DataMember = "Building_counter";
            this.buildingcounterBindingSource.DataSource = this.sFUDataSet12;
            // 
            // building_counterTableAdapter
            // 
            this.building_counterTableAdapter.ClearBeforeFill = true;
            // 
            // зданиеDataGridViewTextBoxColumn
            // 
            this.зданиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.зданиеDataGridViewTextBoxColumn.DataPropertyName = "Здание";
            this.зданиеDataGridViewTextBoxColumn.HeaderText = "Здание";
            this.зданиеDataGridViewTextBoxColumn.Name = "зданиеDataGridViewTextBoxColumn";
            // 
            // кодсчетчикаDataGridViewTextBoxColumn1
            // 
            this.кодсчетчикаDataGridViewTextBoxColumn1.DataPropertyName = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn1.HeaderText = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn1.Name = "кодсчетчикаDataGridViewTextBoxColumn1";
            // 
            // ресурсDataGridViewTextBoxColumn1
            // 
            this.ресурсDataGridViewTextBoxColumn1.DataPropertyName = "Ресурс";
            this.ресурсDataGridViewTextBoxColumn1.HeaderText = "Ресурс";
            this.ресурсDataGridViewTextBoxColumn1.Name = "ресурсDataGridViewTextBoxColumn1";
            // 
            // кодсчетчикаDataGridViewTextBoxColumn
            // 
            this.кодсчетчикаDataGridViewTextBoxColumn.DataPropertyName = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn.HeaderText = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn.Name = "кодсчетчикаDataGridViewTextBoxColumn";
            // 
            // ресурсDataGridViewTextBoxColumn
            // 
            this.ресурсDataGridViewTextBoxColumn.DataPropertyName = "Ресурс";
            this.ресурсDataGridViewTextBoxColumn.HeaderText = "Ресурс";
            this.ресурсDataGridViewTextBoxColumn.Name = "ресурсDataGridViewTextBoxColumn";
            // 
            // коплатеDataGridViewTextBoxColumn
            // 
            this.коплатеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.коплатеDataGridViewTextBoxColumn.DataPropertyName = "К_оплате";
            this.коплатеDataGridViewTextBoxColumn.HeaderText = "К_оплате";
            this.коплатеDataGridViewTextBoxColumn.Name = "коплатеDataGridViewTextBoxColumn";
            // 
            // topaycounterBindingSource
            // 
            this.topaycounterBindingSource.DataMember = "To_pay_counter";
            this.topaycounterBindingSource.DataSource = this.sFUDataSet11;
            // 
            // sFUDataSet11
            // 
            this.sFUDataSet11.DataSetName = "SFUDataSet11";
            this.sFUDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // to_pay_counterTableAdapter
            // 
            this.to_pay_counterTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начисления по счетчикам";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Здания - Счетчики";
            // 
            // FormIndications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormIndications";
            this.Text = "Показания и Начисления";
            this.Load += new System.EventHandler(this.FormIndications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingcounterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topaycounterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private SFUDataSet11 sFUDataSet11;
        private System.Windows.Forms.BindingSource topaycounterBindingSource;
        private SFUDataSet11TableAdapters.To_pay_counterTableAdapter to_pay_counterTableAdapter;
        private SFUDataSet12 sFUDataSet12;
        private System.Windows.Forms.BindingSource buildingcounterBindingSource;
        private SFUDataSet12TableAdapters.Building_counterTableAdapter building_counterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсчетчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ресурсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коплатеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсчетчикаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ресурсDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}