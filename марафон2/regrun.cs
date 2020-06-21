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
using System.Text.RegularExpressions;

namespace марафон2
{
    public partial class regrun : Form
    {
        public regrun()
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
        private void check ()
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" |
                textBox4.Text == "" | textBox5.Text == "" | textBox6.Text == "" |
                comboBox1.Text == "" | comboBox2.Text == "")
                button3.Enabled = false;
            else
                button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox6.Text = openFileDialog1.SafeFileName;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void regrun_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new
                SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Gender FROM Gender";
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    comboBox1.Items.Add(r[0]);
                }
                conn.Close();
                conn.Open();
                SqlCommand cm = conn.CreateCommand();
                cm.CommandText = "SELECT CountryName FROM  Country";
                SqlDataReader rdr = cm.ExecuteReader();
                while (rdr.Read())
                {
                    comboBox2.Items.Add(rdr[0]);
                }
                conn.Close();
            }
            var z = DateTime.Today;
            z = z.AddYears(-10);
            dateTimePicker1.MaxDate = z;
            dateTimePicker1.Value = z;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string expresion = @".+@.+\..+";
            if (Regex.IsMatch(textBox1.Text, expresion))
                textBox1.BackColor = Color.White;
            else
                textBox1.BackColor = Color.Red;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string expresion = @"(?=.*[\d])(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z])(?=.*[!@#$%^]).{6,}";
            if (Regex.IsMatch(textBox2.Text, expresion))
                textBox2.BackColor = Color.White;
            else
                textBox2.BackColor = Color.Red;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text!=textBox2.Text)
            {
                textBox3.BackColor = Color.Red;
                button3.Enabled = false;
            }
            else
            {
                textBox3.BackColor = Color.White;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string code = "";
            using (SqlConnection con = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT CountryCode  FROM Country where CountryName='" +
                    comboBox2.Text + "'OR CountryCode='" + comboBox2.Text + "'";
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    code = r[0].ToString();
                }
                con.Close();
            }
            if (textBox2.Text == textBox3.Text)
            {
                using (SqlConnection con = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Insert into [User] Values ('" + textBox1.Text + "','" +
                        textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','R')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    SqlCommand cm = con.CreateCommand();
                    cm.CommandText = "Insert into Runner Values ('" + textBox1.Text + "','" + comboBox1.Text + "','" +
                        dateTimePicker1.Value + "','" + code + "','" + textBox6.Text + "')";
                    cm.ExecuteNonQuery();
                    con.Close();
                }
                File.WriteAllText("Resources/run.txt", textBox1.Text);
                RegistrM reg = new RegistrM();
                reg.Show();
                this.Close();
            }
        }
    }
}
