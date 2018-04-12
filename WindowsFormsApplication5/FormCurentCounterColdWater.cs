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
    public partial class FormCurentCounterColdWater : Form
    {
        public FormCurentCounterColdWater()
        {
            InitializeComponent();
        }

        private void FormCurentCounterColdtWater_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet2.wvCurentCounterColdWater". При необходимости она может быть перемещена или удалена.
            this.wvCurentCounterColdWaterTableAdapter.Fill(this.sFUDataSet2.wvCurentCounterColdWater);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
