using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace prikoligais
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn = null;
            sqlite_conn = new SQLiteConnection("Data Source=datubaze.db; Version=3; New=True; Compress=True;");

            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return sqlite_conn;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void Ienākt_Click_1(object sender, EventArgs e)
        {
            if (E_pasts.Text != "" && Parole.Text != "")
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO Vards(E_pasts, Parole) VALUES (@E_pasts, @Parole)";
                sqlite_cmd.Parameters.AddWithValue("@E_pasts", E_pasts.Text);
                sqlite_cmd.Parameters.AddWithValue("@Parole", Parole.Text);


            }
            else
            {
                MessageBox.Show("Lūdzu aizpildiet visus laukus");
            }
            if (E_pasts.Text != "" && Parole.Text != "")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void Pierakstities_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
