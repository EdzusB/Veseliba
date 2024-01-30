using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace prikoligais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static SQLiteConnection datubazes_konekcija()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=datubaze.db; Version = 3; New = True; Compress = True;");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
            }
            return sqlite_conn;
        }

        private void registracijas_podzina_Click(object sender, EventArgs e)
        {
        }

        private void PievienotFiziskoAktivitati()
        {
            SQLiteConnection sqlite_conn = datubazes_konekcija();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO fiziska_aktivitate (akt_veids, akt_ilgums) VALUES('" + this.akt_veids.Text + "', '" + this.akt_ilgums.Text + "')";
            sqlite_cmd.ExecuteNonQuery();
        }

        private void PievienotLietotaju()
        {
            SQLiteConnection sqlite_conn = datubazes_konekcija();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO lietotajs (svars, augums, dzimums) VALUES('" + this.svars.Text + "', '" + this.augums.Text + "', '" + this.dzimums.Text + "') ";
            sqlite_cmd.ExecuteNonQuery();
        }

        private void PievienotMiegu()
        {
            SQLiteConnection sqlite_conn = datubazes_konekcija();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO miegs (miega_ilgums) VALUES('" + this.miega_ilgums.Text + "')";
            sqlite_cmd.ExecuteNonQuery();
        }

        private void PievienotUzturu()
        {
            SQLiteConnection sqlite_conn = datubazes_konekcija();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "INSERT INTO uzturs (kalorijas, ediens, izdevumi) VALUES ('" + this.kalorijas.Text + "', '" + this.ediens.Text + "', '" + this.izdevumi.Text + "')";

            sqlite_cmd.ExecuteNonQuery();
        }

        private string Ieteikumi()
        {
            return "Ieteikumi: Veiciet vairāk fiziskās aktivitātes un uzmanieties par veselīgu uzturu!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registracijas_podzina_Click_1(object sender, EventArgs e)
        {
            PievienotUzturu();
            PievienotFiziskoAktivitati();
            PievienotLietotaju();
            PievienotMiegu();

            MessageBox.Show("Dati veiksmīgi ievadīti!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datu_apskate f2 = new Datu_apskate();
            f2.Show();
            Visible = false;
        }
    }
}
