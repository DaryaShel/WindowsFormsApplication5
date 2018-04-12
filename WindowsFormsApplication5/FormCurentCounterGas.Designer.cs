namespace WindowsFormsApplication5
{
    partial class FormCurentCounterGas
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
            this.sFUDataSet3 = new WindowsFormsApplication5.SFUDataSet3();
            this.wvCurentCounterGasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wvCurentCounterGasTableAdapter = new WindowsFormsApplication5.SFUDataSet3TableAdapters.wvCurentCounterGasTableAdapter();
            this.кодсчетчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ресурсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаустановкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапроверкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvCurentCounterGasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодсчетчикаDataGridViewTextBoxColumn,
            this.зданиеDataGridViewTextBoxColumn,
            this.ресурсDataGridViewTextBoxColumn,
            this.датаустановкиDataGridViewTextBoxColumn,
            this.датапроверкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wvCurentCounterGasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // sFUDataSet3
            // 
            this.sFUDataSet3.DataSetName = "SFUDataSet3";
            this.sFUDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wvCurentCounterGasBindingSource
            // 
            this.wvCurentCounterGasBindingSource.DataMember = "wvCurentCounterGas";
            this.wvCurentCounterGasBindingSource.DataSource = this.sFUDataSet3;
            // 
            // wvCurentCounterGasTableAdapter
            // 
            this.wvCurentCounterGasTableAdapter.ClearBeforeFill = true;
            // 
            // кодсчетчикаDataGridViewTextBoxColumn
            // 
            this.кодсчетчикаDataGridViewTextBoxColumn.DataPropertyName = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn.HeaderText = "Код_счетчика";
            this.кодсчетчикаDataGridViewTextBoxColumn.Name = "кодсчетчикаDataGridViewTextBoxColumn";
            // 
            // зданиеDataGridViewTextBoxColumn
            // 
            this.зданиеDataGridViewTextBoxColumn.DataPropertyName = "Здание";
            this.зданиеDataGridViewTextBoxColumn.HeaderText = "Здание";
            this.зданиеDataGridViewTextBoxColumn.Name = "зданиеDataGridViewTextBoxColumn";
            // 
            // ресурсDataGridViewTextBoxColumn
            // 
            this.ресурсDataGridViewTextBoxColumn.DataPropertyName = "Ресурс";
            this.ресурсDataGridViewTextBoxColumn.HeaderText = "Ресурс";
            this.ресурсDataGridViewTextBoxColumn.Name = "ресурсDataGridViewTextBoxColumn";
            // 
            // датаустановкиDataGridViewTextBoxColumn
            // 
            this.датаустановкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_установки";
            this.датаустановкиDataGridViewTextBoxColumn.HeaderText = "Дата_установки";
            this.датаустановкиDataGridViewTextBoxColumn.Name = "датаустановкиDataGridViewTextBoxColumn";
            // 
            // датапроверкиDataGridViewTextBoxColumn
            // 
            this.датапроверкиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датапроверкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_проверки";
            this.датапроверкиDataGridViewTextBoxColumn.HeaderText = "Дата_проверки";
            this.датапроверкиDataGridViewTextBoxColumn.Name = "датапроверкиDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Печать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormCurentCounterGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCurentCounterGas";
            this.Text = "Просмотрр счетчиков. Газ";
            this.Load += new System.EventHandler(this.FormCurentCounterGas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvCurentCounterGasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet3 sFUDataSet3;
        private System.Windows.Forms.BindingSource wvCurentCounterGasBindingSource;
        private SFUDataSet3TableAdapters.wvCurentCounterGasTableAdapter wvCurentCounterGasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсчетчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ресурсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаустановкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапроверкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}