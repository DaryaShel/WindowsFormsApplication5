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
    public partial class FormDeleteCounter : Form
    {
        public FormDeleteCounter()
        {
            InitializeComponent();
        }

        private void FormDeleteCounter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet5.Counter". При необходимости она может быть перемещена или удалена.
            this.counterTableAdapter.Fill(this.sFUDataSet5.Counter);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CommandText;
            if (FormAutentification.Login == "waterc")
            { CommandText = "DELETE FROM [Counter] WHERE Counter_code = '" + textBox1.Text + "' AND Resource_code = 'CW' "; }
            else if (FormAutentification.Login == "waterh")
            { CommandText = "DELETE FROM [Counter] WHERE Counter_code = '" + textBox1.Text + "' AND Resource_code = 'HW' "; }
            else if (FormAutentification.Login == "gas")
            { CommandText = "DELETE FROM [Counter] WHERE Counter_code = '" + textBox1.Text + "' AND Resource_code = 'G' "; }
            else  if (FormAutentification.Login == "electr")
            { CommandText = "DELETE FROM [Counter] WHERE Counter_code = '" + textBox1.Text + "' AND Resource_code = 'E' "; }
            else if (FormAutentification.Login == "admin")
            {
                CommandText = "DELETE FROM [Counter] WHERE Counter_code = '" + textBox1.Text + "'";
            }
            else
            {
                CommandText = "";
            }

            string Connect = " Data Source =.\\SQLEXPRESS; Initial Catalog = SFU; Persist Security Info= True; User ID=sa; Password=BDiSUBD";

            SqlConnection myConnection = new SqlConnection(Connect);
            SqlCommand myCommand = new SqlCommand(CommandText, myConnection);
            myConnection.Open();

            myCommand.ExecuteScalar();
            myConnection.Close();
            this.counterTableAdapter.Fill(this.sFUDataSet5.Counter); //обновление таблицы (табл. заново помещается в грид)
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
