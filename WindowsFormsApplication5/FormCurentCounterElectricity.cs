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
    public partial class FormCurentCounterElectricity : Form
    {
        public FormCurentCounterElectricity()
        {
            InitializeComponent();
        }

        private void FormCurentCounterElectricity_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet.wvCurentCounterElectricity". При необходимости она может быть перемещена или удалена.
            this.wvCurentCounterElectricityTableAdapter.Fill(this.sFUDataSet.wvCurentCounterElectricity);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
