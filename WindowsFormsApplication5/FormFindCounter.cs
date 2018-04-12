using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class FormFindCounter : Form
    {
        string Date;
        public FormFindCounter()
        {
            InitializeComponent();
        }

        private void FormFindCounter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet10.Counter". При необходимости она может быть перемещена или удалена.
            this.counterTableAdapter.Fill(this.sFUDataSet10.Counter, Date);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date = textBox1.Text;
            this.counterTableAdapter.Fill(this.sFUDataSet10.Counter, Date);
        }
    }
}
