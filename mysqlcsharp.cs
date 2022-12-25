using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=test3;User Id=123;password=123");

            int i;

            i = 0;

            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());


            if (i == 0)
            {
                MessageBox.Show("wrong");
            }
            else
            {
                MessageBox.Show("true");
            }

            con.Close();

        }
    }
}
