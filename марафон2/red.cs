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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        DataSet dataSet = new DataSet();
        string str = "Фонд";
        BindingSource bs = new BindingSource();

        private void button2_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time1;
            DateTime initial_time = Convert.ToDateTime("8.07.2020 6:00");
            DateTime current_time = DateTime.Now;
            time1 = initial_time - current_time;
            time.Text = time1.Days.ToString() + " дней " + time1.Hours.ToString() + " часов и " +
            time1.Minutes.ToString() + " минут до старта марафона!";
            check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runner r = new runner();
            r.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            runner r = new runner();
            r.Show();
            this.Close();
        }
        private void check()
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" |
                 comboBox1.Text == "" | comboBox2.Text == "")
                button4.Enabled = false;
            else
                button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox3.Text = openFileDialog1.SafeFileName;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT Gender FROM Gender";
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    comboBox1.Items.Add(r[0]);
                }
                con.Close();

                con.Open();
                SqlCommand cm = con.CreateCommand();
                cmd.CommandText = "SELECT CountryName FROM Country";
                SqlDataReader r1 = cmd.ExecuteReader();
                while (r1.Read())
                {
                    comboBox2.Items.Add(r1[0]);
                }
                con.Close();
            }
            var z = DateTime.Today;
            z = z.AddYears(-10);
            dateTimePicker1.MaxDate = z;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string expresion = @"(?=.*[\d])(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z])(?=.*[!@#$%^]).{6,}";
            if (Regex.IsMatch(textBox4.Text, expresion))
                textBox4.BackColor = Color.White;
            else
                textBox4.BackColor = Color.Red;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text!=textBox4.Text)
            {
                textBox5.BackColor = Color.Red;
                button4.Enabled = false;
            }
            else
            {
                textBox5.BackColor = Color.White;
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string code = "";
            using (SqlConnection con = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT CountryCode FROM Country where CountryName='" + comboBox2.Text + "'OR CountryCode='" + comboBox2.Text + "'";
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    code = r[0].ToString();  
                }
                con.Close();
            }
            if (textBox4.Text == ""&& textBox5.Text == "")
            {
                SqlConnection con = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString);
                //Выборка
                adapter = new SqlDataAdapter("SELECT * FROM [User] INNER JOIN Runner ON [User].Email = Runner.Email", con);
                //Запрос на вставку
                adapter.InsertCommand = new SqlCommand("Update [User] set FirstName='" + 
                    textBox1.Text + "',LastName='" + textBox2.Text + "' where Email='" + label4.Text + "'" +
                    "Update Runner set Gender = '" + comboBox1.Text + "', DateOfBirth = '" + dateTimePicker1.Value + 
                    "', CountryCode = '" + code + "', Image='" + textBox4.Text + "' where Email = '" + label4.Text + "'", con);
                //Создание набора таблиц
                dataSet = new DataSet();
                //Заполнение таблицы
                adapter.Fill(dataSet, str);
                //Привязка к таблице
                bs = new BindingSource(dataSet, str);
                con.Open();
                adapter.InsertCommand.ExecuteNonQuery();
                con.Close();
                runner r = new runner();
                r.Show();
                this.Close();
            }
            else
                if ( textBox4.Text == textBox5.Text && textBox4.Text != "" && textBox5.Text != "")
                {
                SqlConnection con = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString);
                // Выборка
                adapter = new SqlDataAdapter("SELECT * FROM [User] INNER JOIN Runner ON [User].Email = Runner.Email", con);
                // Запрос на вставку 
                adapter.InsertCommand = new SqlCommand("Update [User] set [Password]='" + textBox4.Text + 
                    "',FirstName='" + textBox1.Text + "',LastName='" + textBox2.Text + "' where Email='" + 
                    label4.Text + "'" + "Update Runner set Gender = '" + comboBox1.Text + "', DateOfBirth = '" 
                    + dateTimePicker1.Value + "', CountryCode = '" + code + "', Image='" + textBox3.Text + "' where Email = '" + label4.Text + "'", con);
                //Создание набора таблиц
                dataSet = new DataSet();
                //Заполнение таблицы
                adapter.Fill(dataSet, str);
                //Привязка к таблице 
                bs = new BindingSource(dataSet, str);
                con.Open();
                adapter.InsertCommand.ExecuteNonQuery();
                con.Close();
                runner r = new runner();
                r.Show();
                this.Close();
                }
            else
            {
                MessageBox.Show("Пароли не совпадают.");
            }

        }
    }
}
