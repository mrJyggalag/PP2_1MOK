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
using System.IO;


namespace марафон2
{
    public partial class runner : Form
    {
        public runner()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time1;
            DateTime initial_time = Convert.ToDateTime("8.07.2020 6:00");
            DateTime current_time = DateTime.Now;
            time1 = initial_time - current_time;
            time.Text = time1.Days.ToString() + " дней " + time1.Hours.ToString() + " часов и " +
            time1.Minutes.ToString() + " минут до старта марафона!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contacts c = new contacts();
            c.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string email = File.ReadAllText("Resources/login.txt");
            Form1 ed = new Form1();
            using (SqlConnection con = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT [User].Email, [User].Password, [User].FirstName," +
                    "[User].LastName, Runner.Gender, Runner.DateOfBirth, Runner.CountryCode," +
                    "[Image]FROM [User] INNER JOIN Runner ON [User].Email = Runner.Email where" +
                    "[User].Email='" + email + "'";
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    ed.label4.Text = r["Email"].ToString();
                    ed.textBox1.Text = r["FirstName"].ToString();
                    ed.textBox2.Text = r["LastName"].ToString();
                    ed.comboBox1.Text = r["Gender"].ToString();
                    ed.dateTimePicker1.Value = Convert.ToDateTime(r["DateOfBirth"]);
                    ed.comboBox2.Text = r["CountryCode"].ToString();
                    if (r["Image"].ToString() != "")
                    {
                        ed.pictureBox1.Image = Image.FromFile("Resources/" + r["Image"]);
                    }
                    ed.textBox3.Text = r["Image"].ToString();
                }
                con.Close();
            }
            ed.Show();
            this.Close();
        }
    }
}
