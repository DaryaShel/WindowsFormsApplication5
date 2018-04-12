namespace WindowsFormsApplication5
{
    partial class FormBoilers
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
            this.button1 = new System.Windows.Forms.Button();
            this.sFUDataSet7 = new WindowsFormsApplication5.SFUDataSet7();
            this.wvBoilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wvBoilerTableAdapter = new WindowsFormsApplication5.SFUDataSet7TableAdapters.wvBoilerTableAdapter();
            this.кодбойлераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тарифНормаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тарифВышенормыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvBoilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодбойлераDataGridViewTextBoxColumn,
            this.зданиеDataGridViewTextBoxColumn,
            this.тарифНормаDataGridViewTextBoxColumn,
            this.тарифВышенормыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wvBoilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sFUDataSet7
            // 
            this.sFUDataSet7.DataSetName = "SFUDataSet7";
            this.sFUDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wvBoilerBindingSource
            // 
            this.wvBoilerBindingSource.DataMember = "wvBoiler";
            this.wvBoilerBindingSource.DataSource = this.sFUDataSet7;
            // 
            // wvBoilerTableAdapter
            // 
            this.wvBoilerTableAdapter.ClearBeforeFill = true;
            // 
            // кодбойлераDataGridViewTextBoxColumn
            // 
            this.кодбойлераDataGridViewTextBoxColumn.DataPropertyName = "Код_бойлера";
            this.кодбойлераDataGridViewTextBoxColumn.HeaderText = "Код_бойлера";
            this.кодбойлераDataGridViewTextBoxColumn.Name = "кодбойлераDataGridViewTextBoxColumn";
            // 
            // зданиеDataGridViewTextBoxColumn
            // 
            this.зданиеDataGridViewTextBoxColumn.DataPropertyName = "Здание";
            this.зданиеDataGridViewTextBoxColumn.HeaderText = "Здание";
            this.зданиеDataGridViewTextBoxColumn.Name = "зданиеDataGridViewTextBoxColumn";
            // 
            // тарифНормаDataGridViewTextBoxColumn
            // 
            this.тарифНормаDataGridViewTextBoxColumn.DataPropertyName = "Тариф_Норма";
            this.тарифНормаDataGridViewTextBoxColumn.HeaderText = "Тариф_Норма";
            this.тарифНормаDataGridViewTextBoxColumn.Name = "тарифНормаDataGridViewTextBoxColumn";
            // 
            // тарифВышенормыDataGridViewTextBoxColumn
            // 
            this.тарифВышенормыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.тарифВышенормыDataGridViewTextBoxColumn.DataPropertyName = "Тариф_Выше_нормы";
            this.тарифВышенормыDataGridViewTextBoxColumn.HeaderText = "Тариф_Выше_нормы";
            this.тарифВышенормыDataGridViewTextBoxColumn.Name = "тарифВышенормыDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormBoilers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBoilers";
            this.Text = "Бойлеры";
            this.Load += new System.EventHandler(this.FormBoilers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvBoilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private SFUDataSet7 sFUDataSet7;
        private System.Windows.Forms.BindingSource wvBoilerBindingSource;
        private SFUDataSet7TableAdapters.wvBoilerTableAdapter wvBoilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодбойлераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тарифНормаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тарифВышенормыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}