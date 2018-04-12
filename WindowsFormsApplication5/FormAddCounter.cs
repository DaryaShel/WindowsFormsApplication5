using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class FormAddCounter : Form
    {
        public FormAddCounter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAddCounter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet4.Counter". При необходимости она может быть перемещена или удалена.
            this.counterTableAdapter.Fill(this.sFUDataSet4.Counter);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((FormAutentification.Login == "waterc" && textBox2.Text != "CW") || (FormAutentification.Login == "waterh" && textBox2.Text != "HW") || (FormAutentification.Login == "gas" && textBox2.Text != "G") || (FormAutentification.Login == "electr" && textBox2.Text != "E"))
            { MessageBox.Show("Нет прав доступа!"); }
            else
            {
                String counter_code = textBox1.Text;
                String resource_code = textBox2.Text;
                DateTime test_date = Convert.ToDateTime(textBox3.Text);
                // Create a new row.
                SFUDataSet4.CounterRow newCounterRow;
                newCounterRow = this.sFUDataSet4.Counter.NewCounterRow();
                newCounterRow.Counter_code = counter_code;
                newCounterRow.Resource_code = resource_code;
                newCounterRow.Installation_date = DateTime.Now;
                newCounterRow.Test_date = test_date;
                // Add the row to the Region table
                this.sFUDataSet4.Counter.Rows.Add(newCounterRow);

                // Save the new row to the database
                this.counterTableAdapter.Update(this.sFUDataSet4.Counter);
            }
        }
    }
}
