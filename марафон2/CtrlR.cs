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
    public partial class CtrlR : Form
    {
        public CtrlR()
        {
            InitializeComponent();
        }
        int z = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time1;
            DateTime initial_time = Convert.ToDateTime("8.07.2020 6:00");
            DateTime current_time = DateTime.Now;
            time1 = initial_time - current_time;
            time.Text = time1.Days.ToString() + " дней " + time1.Hours.ToString() + " часов и " +
            time1.Minutes.ToString() + " минут до старта марафона!";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            coordinators c = new coordinators();
            c.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Close();
        }

        private void CtrlR_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT RegistrationStatus FROM RegistrationStatus";
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    comboBox1.Items.Add(r["RegistrationStatus"]);
                }
                conn.Close();
                conn.Open();
                SqlCommand cm = conn.CreateCommand();
                cm.CommandText = "SELECT EventTypeName FROM EventType";
                SqlDataReader re = cm.ExecuteReader();
                while (re.Read())
                {
                    comboBox2.Items.Add(re["EventTypeName"]);
                }
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Clear();
            using (SqlConnection conn = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT[User].FirstName AS Имя, [User].LastName AS Фамилия, [User].Email,[RegistrationStatus].RegistrationStatus AS Статус FROM Event INNER JOIN EventType ON Event.EventTypeId = EventType.EventTypeId INNER JOIN RegistrationEvent ON Event.EventId = RegistrationEvent.EventId INNER JOIN Runner INNER JOIN[User] ON Runner.Email = [User].Email INNER JOIN Registration ON Runner.RunnerId = Registration.RunnerId INNER JOIN RegistrationStatus ON Registration.RegistrationStatusId = RegistrationStatus.RegistrationStatusId ON RegistrationEvent.RegistrationId = Registration.RegistrationId WHERE([User].RoleId = N'R')AND(RegistrationStatus.RegistrationStatus = N'" + comboBox1.Text + "') AND(EventType.EventTypeName = N'" + comboBox2.Text + "')", conn))
            {
                da.Fill(ds, "table");
                dataGridView1.DataSource = ds.Tables["table"];
                if (z==0)
                {
                    DataGridViewButtonColumn bt = new DataGridViewButtonColumn();
                    dataGridView1.Columns.Add(bt);
                    bt.Text = "Редактировать";
                    bt.UseColumnTextForButtonValue = true;
                }
            }
            label8.Text = dataGridView1.RowCount.ToString();
            z++;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
            {
                var csv = new StringBuilder();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT [User].FirstName, [User].LastName, [User].Email, Gender.Gender, Country.CountryName, Runner.DateOfBirth, year(getdate())-year(Runner.DateOfBirth) AS Возраст, RegistrationStatus.RegistrationStatus, RaceKitOption.RaceKitOption, EventType.EventTypeName FROM RegistrationStatus INNER JOIN EventType INNER JOIN Event ON EventType.EventTypeId = Event.EventTypeId INNER JOIN Marathon ON Event.MarathonId = Marathon.MarathonId INNER JOIN Country ON Marathon.CountryCode = Country.CountryCode INNER JOIN Registration INNER JOIN RaceKitOption ON Registration.RaceKitOptionId = RaceKitOption.RaceKitOptionId INNER JOIN RegistrationEvent ON Registration.RegistrationId = RegistrationEvent.RegistrationId ON Event.EventId = RegistrationEvent.EventId ON RegistrationStatus.RegistrationStatusId = Registration.RegistrationStatusId INNER JOIN Runner ON Country.CountryCode = Runner.CountryCode AND Registration.RunnerId = Runner.RunnerId INNER JOIN Gender ON Runner.Gender = Gender.Gender INNER JOIN [User] ON Runner.Email = [User].Email  WHERE([User].RoleId = N'R') AND(RegistrationStatus.RegistrationStatus = N'" + comboBox1.Text + "') AND(EventType.EventTypeName = N'" + comboBox2.Text + "')";
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read ())
                {
                    var one = r["FirstName"].ToString();
                    var two = r["LastName"].ToString();
                    var three = r["Email"].ToString();
                    var four = r["Gender"].ToString();
                    var five = r["CountryName"].ToString();
                    var six = r["DateOfBirth"].ToString();
                    var seven = r["Возраст"].ToString();
                    var eight = r["RegistrationStatus"].ToString();
                    var nine = r["RaceKitOption"].ToString();
                    var ten = r["EventTypeName"].ToString();
                    var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", one, two, three, four, five, six, seven, eight, nine, ten);
                    csv.AppendLine(newLine);
                }
                conn.Close();
                string tempPath = "";
                if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
                {
                    tempPath = folderBrowserDialog1.SelectedPath;
                }
                File.WriteAllText(tempPath + "\\runner.csv", csv.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(марафон2.Properties.Settings.Default.MaraphonConnectionString))
            {
                email em = new email();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT [User].FirstName, [User].LastName, [User].Email FROM Event INNER JOIN EventType ON Event.EventTypeId = EventType.EventTypeId INNER JOIN Marathon ON Event.MarathonId = Marathon.MarathonId INNER JOIN RegistrationEvent ON Event.EventId = RegistrationEvent.EventId INNER JOIN Registration ON RegistrationEvent.RegistrationId = Registration.RegistrationId INNER JOIN RegistrationStatus ON Registration.RegistrationStatusId = RegistrationStatus.RegistrationStatusId INNER JOIN Runner ON Registration.RunnerId = Runner.RunnerId INNER JOIN [User] ON Runner.Email = [User].Email WHERE([User].RoleId = N'R') AND(RegistrationStatus.RegistrationStatus = N'" + comboBox1.Text + "') AND(EventType.EventTypeName = N'" + comboBox2.Text + "')";
                SqlDataReader r = cmd.ExecuteReader();
                while ( r.Read())
                {
                    
                    var one = r["FirstName"].ToString();
                    var two = r["LastName"].ToString();
                    var three = r["Email"].ToString();
                    var newLine = string.Format("'{0} {1}' <{2}>; ", one, two, three);
                    em.textBox1.Text += newLine;

                }
                conn.Close();
                em.ShowDialog();
            }
        }
    }
}
