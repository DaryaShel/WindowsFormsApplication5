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
    public partial class FormUpdateCounter : Form
    {
        public FormUpdateCounter()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                string CommandText = "UPDATE [Counter] SET Counter_code = '" + textBox3.Text + "' WHERE Counter_number = '" + Convert.ToInt32(textBox2.Text) + "'";
                string Connect = " Data Source =.\\SQLEXPRESS; Initial Catalog = SFU; Persist Security Info= True; User ID=sa; Password=BDiSUBD";
                SqlConnection myConnection = new SqlConnection(Connect);
                SqlCommand myCommand = new SqlCommand(CommandText, myConnection);
                myConnection.Open();
                myCommand.ExecuteScalar();
                myConnection.Close();
                this.counterTableAdapter.Fill(this.sFUDataSet6.Counter); //обновление таблицы (табл. заново помещается в грид)
            }
            else if (textBox1.Text == "2")
            {
                string CommandText = "UPDATE [Counter] SET Resource_code = '" + textBox3.Text + "' WHERE Counter_number = '" + Convert.ToInt32(textBox2.Text) + "'";
                string Connect = " Data Source =.\\SQLEXPRESS; Initial Catalog = SFU; Persist Security Info= True; User ID=sa; Password=BDiSUBD";
                SqlConnection myConnection = new SqlConnection(Connect);
                SqlCommand myCommand = new SqlCommand(CommandText, myConnection);
                myConnection.Open();
                myCommand.ExecuteScalar();
                myConnection.Close();
                this.counterTableAdapter.Fill(this.sFUDataSet6.Counter); //обновление таблицы (табл. заново помещается в грид)
            }
            else if (textBox1.Text == "3")
            {
                string CommandText = "UPDATE [Counter] SET Test_date = '" + Convert.ToDateTime(textBox3.Text) + "' WHERE Counter_number = '" + Convert.ToInt32(textBox2.Text) + "'";
                string Connect = " Data Source =.\\SQLEXPRESS; Initial Catalog = SFU; Persist Security Info= True; User ID=sa; Password=BDiSUBD";
                SqlConnection myConnection = new SqlConnection(Connect);
                SqlCommand myCommand = new SqlCommand(CommandText, myConnection);
                myConnection.Open();
                myCommand.ExecuteScalar();
                myConnection.Close();
                this.counterTableAdapter.Fill(this.sFUDataSet6.Counter); //обновление таблицы (табл. заново помещается в грид)
            }
            else if (textBox1.Text == "4")
            {
                string CommandText = "UPDATE [Counter] SET Breaking_date = '" + Convert.ToDateTime(textBox3.Text) + "' WHERE Counter_number = '" + Convert.ToInt32(textBox2.Text) + "'";
                string Connect = " Data Source =.\\SQLEXPRESS; Initial Catalog = SFU; Persist Security Info= True; User ID=sa; Password=BDiSUBD";
                SqlConnection myConnection = new SqlConnection(Connect);
                SqlCommand myCommand = new SqlCommand(CommandText, myConnection);
                myConnection.Open();
                myCommand.ExecuteScalar();
                myConnection.Close();
                this.counterTableAdapter.Fill(this.sFUDataSet6.Counter); //обновление таблицы (табл. заново помещается в грид)
            }
        }

        private void FormUpdateCounter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sFUDataSet6.Counter". При необходимости она может быть перемещена или удалена.
            this.counterTableAdapter.Fill(this.sFUDataSet6.Counter);

        }
    }
}
