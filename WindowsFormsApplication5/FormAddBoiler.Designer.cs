namespace WindowsFormsApplication5
{
    partial class FormAddBoiler
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sFUDataSet9 = new WindowsFormsApplication5.SFUDataSet9();
            this.boilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boilerTableAdapter = new WindowsFormsApplication5.SFUDataSet9TableAdapters.BoilerTableAdapter();
            this.boilernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boilercodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourcecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boilernumberDataGridViewTextBoxColumn,
            this.boilercodeDataGridViewTextBoxColumn,
            this.installationdateDataGridViewTextBoxColumn,
            this.testdateDataGridViewTextBoxColumn,
            this.breakingdateDataGridViewTextBoxColumn,
            this.resourcecodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ввести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Код бойлера";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата поверки";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // sFUDataSet9
            // 
            this.sFUDataSet9.DataSetName = "SFUDataSet9";
            this.sFUDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boilerBindingSource
            // 
            this.boilerBindingSource.DataMember = "Boiler";
            this.boilerBindingSource.DataSource = this.sFUDataSet9;
            // 
            // boilerTableAdapter
            // 
            this.boilerTableAdapter.ClearBeforeFill = true;
            // 
            // boilernumberDataGridViewTextBoxColumn
            // 
            this.boilernumberDataGridViewTextBoxColumn.DataPropertyName = "Boiler_number";
            this.boilernumberDataGridViewTextBoxColumn.HeaderText = "Boiler_number";
            this.boilernumberDataGridViewTextBoxColumn.Name = "boilernumberDataGridViewTextBoxColumn";
            this.boilernumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boilercodeDataGridViewTextBoxColumn
            // 
            this.boilercodeDataGridViewTextBoxColumn.DataPropertyName = "Boiler_code";
            this.boilercodeDataGridViewTextBoxColumn.HeaderText = "Boiler_code";
            this.boilercodeDataGridViewTextBoxColumn.Name = "boilercodeDataGridViewTextBoxColumn";
            // 
            // installationdateDataGridViewTextBoxColumn
            // 
            this.installationdateDataGridViewTextBoxColumn.DataPropertyName = "Installation_date";
            this.installationdateDataGridViewTextBoxColumn.HeaderText = "Installation_date";
            this.installationdateDataGridViewTextBoxColumn.Name = "installationdateDataGridViewTextBoxColumn";
            // 
            // testdateDataGridViewTextBoxColumn
            // 
            this.testdateDataGridViewTextBoxColumn.DataPropertyName = "Test_date";
            this.testdateDataGridViewTextBoxColumn.HeaderText = "Test_date";
            this.testdateDataGridViewTextBoxColumn.Name = "testdateDataGridViewTextBoxColumn";
            // 
            // breakingdateDataGridViewTextBoxColumn
            // 
            this.breakingdateDataGridViewTextBoxColumn.DataPropertyName = "Breaking_date";
            this.breakingdateDataGridViewTextBoxColumn.HeaderText = "Breaking_date";
            this.breakingdateDataGridViewTextBoxColumn.Name = "breakingdateDataGridViewTextBoxColumn";
            // 
            // resourcecodeDataGridViewTextBoxColumn
            // 
            this.resourcecodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resourcecodeDataGridViewTextBoxColumn.DataPropertyName = "Resource_code";
            this.resourcecodeDataGridViewTextBoxColumn.HeaderText = "Resource_code";
            this.resourcecodeDataGridViewTextBoxColumn.Name = "resourcecodeDataGridViewTextBoxColumn";
            // 
            // FormAddBoiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 277);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAddBoiler";
            this.Text = "FormAddBoiler";
            this.Load += new System.EventHandler(this.FormAddBoiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private SFUDataSet9 sFUDataSet9;
        private System.Windows.Forms.BindingSource boilerBindingSource;
        private SFUDataSet9TableAdapters.BoilerTableAdapter boilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boilernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boilercodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourcecodeDataGridViewTextBoxColumn;
    }
}