namespace WindowsFormsApplication5
{
    partial class FormCurentCounterHotWater
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
            this.sFUDataSet1 = new WindowsFormsApplication5.SFUDataSet1();
            this.wvCurentCounterHotWaterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wvCurentCounterHotWaterTableAdapter = new WindowsFormsApplication5.SFUDataSet1TableAdapters.wvCurentCounterHotWaterTableAdapter();
            this.кодсчетчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ресурсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаустановкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапроверкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvCurentCounterHotWaterBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.wvCurentCounterHotWaterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // sFUDataSet1
            // 
            this.sFUDataSet1.DataSetName = "SFUDataSet1";
            this.sFUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wvCurentCounterHotWaterBindingSource
            // 
            this.wvCurentCounterHotWaterBindingSource.DataMember = "wvCurentCounterHotWater";
            this.wvCurentCounterHotWaterBindingSource.DataSource = this.sFUDataSet1;
            // 
            // wvCurentCounterHotWaterTableAdapter
            // 
            this.wvCurentCounterHotWaterTableAdapter.ClearBeforeFill = true;
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
            this.button1.Location = new System.Drawing.Point(600, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Печать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormCurentCounterHotWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 207);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCurentCounterHotWater";
            this.Text = "Просмотр счетчиков. Горячая вода";
            this.Load += new System.EventHandler(this.FormCurentCounterHotWater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvCurentCounterHotWaterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet1 sFUDataSet1;
        private System.Windows.Forms.BindingSource wvCurentCounterHotWaterBindingSource;
        private SFUDataSet1TableAdapters.wvCurentCounterHotWaterTableAdapter wvCurentCounterHotWaterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсчетчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ресурсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаустановкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапроверкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}