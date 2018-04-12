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
    public partial class FormCurentCounter : Form
    {
        public FormCurentCounter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCurentCounterElectricity form_curent_counter_electricity = new FormCurentCounterElectricity();
            form_curent_counter_electricity.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCurentCounterHotWater form_curent_counter_hot_water = new FormCurentCounterHotWater();
            form_curent_counter_hot_water.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCurentCounterColdWater form_curent_counter_cold_water = new FormCurentCounterColdWater();
            form_curent_counter_cold_water.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCurentCounterGas form_curent_counter_gas = new FormCurentCounterGas();
            form_curent_counter_gas.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormFindCounter form_find_counter = new FormFindCounter();
            form_find_counter.Show();
        }
    }
}
