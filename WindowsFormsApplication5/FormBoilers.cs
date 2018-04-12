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
    public partial class FormBoilers : Form
    {
        public FormBoilers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormBoilers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet7.wvBoiler". При необходимости она может быть перемещена или удалена.
            this.wvBoilerTableAdapter.Fill(this.sFUDataSet7.wvBoiler);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddBoiler form_add_boiler = new FormAddBoiler();
            form_add_boiler.ShowDialog();
        }
    }
}
