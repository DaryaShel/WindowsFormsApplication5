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
    public partial class FormAddBoiler : Form
    {
        public FormAddBoiler()
        {
            InitializeComponent();
        }

        private void FormAddBoiler_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet9.Boiler". При необходимости она может быть перемещена или удалена.
            this.boilerTableAdapter.Fill(this.sFUDataSet9.Boiler);       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SFUDataSet9.BoilerRow newBoilerRow;
            newBoilerRow = this.sFUDataSet9.Boiler.NewBoilerRow();
            newBoilerRow.Boiler_code = Convert.ToInt32(textBox1.Text);
            newBoilerRow.Installation_date = DateTime.Now;
            newBoilerRow.Test_date = Convert.ToDateTime(textBox2.Text);
            newBoilerRow.Resource_code = "H";

            this.sFUDataSet9.Boiler.Rows.Add(newBoilerRow);
            this.boilerTableAdapter.Update(this.sFUDataSet9.Boiler);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
