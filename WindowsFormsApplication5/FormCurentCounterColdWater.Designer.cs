namespace WindowsFormsApplication5
{
    partial class FormCurentCounterColdWater
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
            this.sFUDataSet2 = new WindowsFormsApplication5.SFUDataSet2();
            this.wvCurentCounterColdWaterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wvCurentCounterColdWaterTableAdapter = new WindowsFormsApplication5.SFUDataSet2TableAdapters.wvCurentCounterColdWaterTableAdapter();
            this.кодсчетчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ресурсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаустановкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапроверкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvCurentCounterColdWaterBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.wvCurentCounterColdWaterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // sFUDataSet2
            // 
            this.sFUDataSet2.DataSetName = "SFUDataSet2";
            this.sFUDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wvCurentCounterColdWaterBindingSource
            // 
            this.wvCurentCounterColdWaterBindingSource.DataMember = "wvCurentCounterColdWater";
            this.wvCurentCounterColdWaterBindingSource.DataSource = this.sFUDataSet2;
            // 
            // wvCurentCounterColdWaterTableAdapter
            // 
            this.wvCurentCounterColdWaterTableAdapter.ClearBeforeFill = true;
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
            this.button1.Location = new System.Drawing.Point(598, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Печать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormCurentCounterColdtWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 199);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCurentCounterColdtWater";
            this.Text = "Просмотр счетчиков. Холодная вода";
            this.Load += new System.EventHandler(this.FormCurentCounterColdtWater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFUDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvCurentCounterColdWaterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SFUDataSet2 sFUDataSet2;
        private System.Windows.Forms.BindingSource wvCurentCounterColdWaterBindingSource;
        private SFUDataSet2TableAdapters.wvCurentCounterColdWaterTableAdapter wvCurentCounterColdWaterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодсчетчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ресурсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаустановкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапроверкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}