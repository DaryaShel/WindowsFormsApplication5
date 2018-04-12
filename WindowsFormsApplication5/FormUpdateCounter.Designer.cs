namespace WindowsFormsApplication5
{
    partial class FormUpdateCounter
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
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sFUDataSet6 = new WindowsFormsApplication5.SFUDataSet6();
            this.counterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counterTableAdapter = new WindowsFormsApplication5.SFUDataSet6TableAdapters.CounterTableAdapter();
            this.counternumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countercodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourcecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastBreakingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(579, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Ввод";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.counternumberDataGridViewTextBoxColumn,
            this.countercodeDataGridViewTextBoxColumn,
            this.resourcecodeDataGridViewTextBoxColumn,
            this.installationdateDataGridViewTextBoxColumn,
            this.testdateDataGridViewTextBoxColumn,
            this.lastBreakingdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.counterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(403, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(403, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Новое значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Номер счетчика";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 65);
            this.label1.TabIndex = 17;
            this.label1.Text = "Изменить данные в таблице \"Счетчик\"\r\nКод счетчика - 1\r\nКод ресурса - 2\r\nДата тест" +
    "ирования - 3\r\nДата поломки - 4";
            // 
            // sFUDataSet6
            // 
            this.sFUDataSet6.DataSetName = "SFUDataSet6";
            this.sFUDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // counterBindingSource
            // 
            this.counterBindingSource.DataMember = "Counter";
            this.counterBindingSource.DataSource = this.sFUDataSet6;
            // 
            // counterTableAdapter
            // 
            this.counterTableAdapter.ClearBeforeFill = true;
            // 
            // counternumberDataGridViewTextBoxColumn
            // 
            this.counternumberDataGridViewTextBoxColumn.DataPropertyName = "Counter_number";
            this.counternumberDataGridViewTextBoxColumn.HeaderText = "Counter_number";
            this.counternumberDataGridViewTextBoxColumn.Name = "counternumberDataGridViewTextBoxColumn";
            this.counternumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countercodeDataGridViewTextBoxColumn
            // 
            this.countercodeDataGridViewTextBoxColumn.DataPropertyName = "Counter_code";
            this.countercodeDataGridViewTextBoxColumn.HeaderText = "Counter_code";
            this.countercodeDataGridViewTextBoxColumn.Name = "countercodeDataGridViewTextBoxColumn";
            // 
            // resourcecodeDataGridViewTextBoxColumn
            // 
            this.resourcecodeDataGridViewTextBoxColumn.DataPropertyName = "Resource_code";
            this.resourcecodeDataGridViewTextBoxColumn.HeaderText = "Resource_code";
            this.resourcecodeDataGridViewTextBoxColumn.Name = "resourcecodeDataGridViewTextBoxColumn";
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
            // lastBreakingdateDataGridViewTextBoxColumn
            // 
            this.lastBreakingdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastBreakingdateDataGridViewTextBoxColumn.DataPropertyName = "Last_Breaking_date";
            this.lastBreakingdateDataGridViewTextBoxColumn.HeaderText = "Last_Breaking_date";
            this.lastBreakingdateDataGridViewTextBoxColumn.Name = "lastBreakingdateDataGridViewTextBoxColumn";
            // 
            // FormUpdateCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 323);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateCounter";
            this.Text = "FormUpdateCounter";
            this.Load += new System.EventHandler(this.FormUpdateCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SFUDataSet6 sFUDataSet6;
        private System.Windows.Forms.BindingSource counterBindingSource;
        private SFUDataSet6TableAdapters.CounterTableAdapter counterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn counternumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countercodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourcecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastBreakingdateDataGridViewTextBoxColumn;
    }
}