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
    public partial class FormCurentCounterHotWater : Form
    {
        public FormCurentCounterHotWater()
        {
            InitializeComponent();
        }

        private void FormCurentCounterHotWater_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet1.wvCurentCounterHotWater". При необходимости она может быть перемещена или удалена.
            this.wvCurentCounterHotWaterTableAdapter.Fill(this.sFUDataSet1.wvCurentCounterHotWater);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
