namespace WindowsFormsApplication5
{
    partial class FormDeleteCounter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sFUDataSet5 = new WindowsFormsApplication5.SFUDataSet5();
            this.counterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counterTableAdapter = new WindowsFormsApplication5.SFUDataSet5TableAdapters.CounterTableAdapter();
            this.counternumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countercodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourcecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastBreakingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 164);
            this.dataGridView1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Код счетчика";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sFUDataSet5
            // 
            this.sFUDataSet5.DataSetName = "SFUDataSet5";
            this.sFUDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // counterBindingSource
            // 
            this.counterBindingSource.DataMember = "Counter";
            this.counterBindingSource.DataSource = this.sFUDataSet5;
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
            // FormDeleteCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 249);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormDeleteCounter";
            this.Text = "FormDeleteCounter";
            this.Load += new System.EventHandler(this.FormDeleteCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private SFUDataSet5 sFUDataSet5;
        private System.Windows.Forms.BindingSource counterBindingSource;
        private SFUDataSet5TableAdapters.CounterTableAdapter counterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn counternumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countercodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourcecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastBreakingdateDataGridViewTextBoxColumn;
    }
}