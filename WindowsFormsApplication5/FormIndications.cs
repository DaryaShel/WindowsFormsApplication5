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
    public partial class FormIndications : Form
    {
        public FormIndications()
        {
            InitializeComponent();
        }

        private void FormIndications_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet12.Building_counter". При необходимости она может быть перемещена или удалена.
            this.building_counterTableAdapter.Fill(this.sFUDataSet12.Building_counter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet11.To_pay_counter". При необходимости она может быть перемещена или удалена.
            this.to_pay_counterTableAdapter.Fill(this.sFUDataSet11.To_pay_counter);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
