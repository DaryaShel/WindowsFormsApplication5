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
    public partial class FormCounter : Form
    {
        public FormCounter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCurentCounter form_curent_counter = new FormCurentCounter();
            form_curent_counter.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddCounter form_add_counter = new FormAddCounter();
            form_add_counter.ShowDialog();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDeleteCounter form_delete_counter = new FormDeleteCounter();
            form_delete_counter.ShowDialog();
        }
    }
}
