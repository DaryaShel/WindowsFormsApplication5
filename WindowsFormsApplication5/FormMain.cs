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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCounter form_counter = new FormCounter();
            form_counter.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBoilers  form_boilers = new FormBoilers();
            form_boilers.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormIndications form_indications = new FormIndications();
            form_indications.Show();
        }
    }
}
