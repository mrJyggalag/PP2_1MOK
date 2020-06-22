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
    public partial class RegistrM : Form
    {
        public RegistrM()
        {
            InitializeComponent();
        }

        string kit = "";
        int cost = 0;
        int b = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time1;
            DateTime initial_time = Convert.ToDateTime("8.07.2020 6:00");
            DateTime current_time = DateTime.Now;
            time1 = initial_time - current_time;
            time.Text = time1.Days.ToString() + " дней " + time1.Hours.ToString() + " часов и " +
            time1.Minutes.ToString() + " минут до старта марафона!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runner r = new runner();
            r.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void RegistrM_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT CharityName FROM Charity";
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    comboBox1.Items.Add(r[0]);
                }
                con.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                label8.Text = (Convert.ToInt32(label8.Text) + 145).ToString();
            else
                label8.Text = (Convert.ToInt32(label8.Text) - 145).ToString();
            if(checkBox1.Checked==true||checkBox2.Checked==true|| checkBox3.Checked==true)
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                label8.Text = (Convert.ToInt32(label8.Text) + 75).ToString();
            else
                label8.Text = (Convert.ToInt32(label8.Text) - 75).ToString();
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                label8.Text = (Convert.ToInt32(label8.Text) + 20).ToString();
            else
                label8.Text = (Convert.ToInt32(label8.Text) - 20).ToString();
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                kit = "A";
                cost = 0;
                label8.Text = (Convert.ToInt32(label8.Text) + 0).ToString();
            }
            else
                label8.Text = (Convert.ToInt32(label8.Text) - 0).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                kit = "B";
                cost = 20;
                label8.Text = (Convert.ToInt32(label8.Text) + 20).ToString();
            }
            else
                label8.Text = (Convert.ToInt32(label8.Text) - 20).ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                kit = "C";
                cost = 0;
                label8.Text = (Convert.ToInt32(label8.Text) + 45).ToString();
            }
            else
                label8.Text = (Convert.ToInt32(label8.Text) - 45).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                textBox1.Text = "0";
                label8.Text = (Convert.ToInt32(label8) - b).ToString();
            }
  
            label8.Text = (b+ Convert.ToInt32(textBox1.Text) ).ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt32(label8.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fond f = new fond();
            using (SqlConnection con = new SqlConnection (марафон2.Properties.Settings.Default.MaraphonConnectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT CharityName,CharityDescription,CharityLogo  FROM Charity WHERE CharityName=" + comboBox1.Text + "";
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    f.label1.Text = r["CharityName"].ToString();
                    f.textBox1.Text = r["CharityDescription"].ToString();
                    f.pictureBox1.Image = Image.FromFile("Resources/" + r["CharityLogo"].ToString());
                }
                con.Close();
            }
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string charity = "";
            string rid = "";
            string email = File.ReadAllText("Resources/run.txt");
            using (SqlConnection con =  new SqlConnection (марафон2.Properties.Settings.Default.MaraphonConnectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT RunnerID FROM Runner where Email= '" + email + "'";
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    rid = r[0].ToString();
                }
                con.Close();
                con.Open();
                SqlCommand cm = con.CreateCommand();
                cm.CommandText = "SELECT CharityId FROM Charity where CharityName = '" + comboBox1.Text + "'";
                SqlDataReader r1 = cm.ExecuteReader();
                while(r1.Read())
                {
                    charity = r1[0].ToString();
                }
                con.Close();
            }   
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            {
                using (SqlConnection con = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Insert into Registration Values ('" + rid + "','" + DateTime.Today + "','" + kit + "','4','" + cost + "','" + charity + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                completerunner cpltr = new completerunner();
                cpltr.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не выбрали марафон.");
            }
        }
    }
}
