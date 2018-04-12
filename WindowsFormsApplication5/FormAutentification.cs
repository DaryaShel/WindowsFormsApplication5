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
    

    public partial class FormAutentification : Form
    {
        static public string Login;
        public FormAutentification()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT * FROM UsserID WHERE Login= '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'";
            string Connect = " Data Source =.\\SQLEXPRESS; Initial Catalog = SFU; Integrated Security = True";

            SqlConnection myConnection = new SqlConnection(Connect);
            SqlCommand myCommand = new SqlCommand(CommandText, myConnection);
            myConnection.Open();
            if (myCommand.ExecuteScalar() != null)
            {
                Login = textBox1.Text;
                FormMain main = new FormMain();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пороль");
            }
            myConnection.Close(); 
        }
    }
}
