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
    public partial class FormCurentCounterGas : Form
    {
        public FormCurentCounterGas()
        {
            InitializeComponent();
        }

        private void FormCurentCounterGas_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet3.wvCurentCounterGas". При необходимости она может быть перемещена или удалена.
            this.wvCurentCounterGasTableAdapter.Fill(this.sFUDataSet3.wvCurentCounterGas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
