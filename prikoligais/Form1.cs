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



        private void PievienotLietotaju()
        {
            SQLiteConnection sqlite_conn = datubazes_konekcija();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO lietotajs (svars, augums, dzimums) VALUES('" + this.svars.Text + "', '" + this.augums.Text + "', '" + this.dzimums.Text + "') ";
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
            aktivitates akt = new aktivitates();
            akt.aktivitesilgums = akt_ilgums.Text;
            akt.aktivitatesveids = akt_veids.Text;
            akt.PievienotFiziskoAktivitati();
            akt.ieteikums();
            uzturs uzt = new uzturs();
            uzt.uznemtaskal = kalorijas.Text;
            uzt.uznemtaisediens = ediens.Text;
            uzt.nauda = izdevumi.Text;
            uzt.miegailgums = miega_ilgums.Text;
            uzt.ieteikums();
            uzt.PievienotMiegu();
            uzt.PievienotUzturu();
            PievienotLietotaju();


            MessageBox.Show("Dati veiksmīgi ievadīti!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datu_apskate f2 = new Datu_apskate();
            f2.Show();
            Visible = false;
        }

        private void miega_ilgums_TextChanged(object sender, EventArgs e)
        {

        }
        class aktivitates
        {
            public string aktivitesilgums { get; set; }
            public string aktivitatesveids { get; set; }
            public void PievienotFiziskoAktivitati()
            {
                SQLiteConnection sqlite_conn = datubazes_konekcija();
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO fiziska_aktivitate (akt_veids, akt_ilgums) VALUES('" + aktivitesilgums + "', '" + aktivitatesveids + "')";
                sqlite_cmd.ExecuteNonQuery();
            }
            public void ieteikums()
            {
                //pēc noteiktiem nosacījumiem izlasa no DB ieteikumu un izvada to uz ekrāna
            }

        }
        class uzturs
        {
            public string uznemtaskal { get; set; }
            public string uznemtaisediens { get; set; }
            public string nauda { get; set; }
            public string miegailgums { get; set; }
            public void PievienotMiegu()
            {
                SQLiteConnection sqlite_conn = datubazes_konekcija();
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO miegs (miega_ilgums) VALUES('" + miegailgums + "')";
                sqlite_cmd.ExecuteNonQuery();
            }
            public void PievienotUzturu()
            {
                SQLiteConnection sqlite_conn = datubazes_konekcija();
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

                sqlite_cmd.CommandText = "INSERT INTO uzturs (kalorijas, ediens, izdevumi) VALUES ('" + uznemtaskal + "', '" + uznemtaisediens + "', '" + nauda + "')";

                sqlite_cmd.ExecuteNonQuery();
            }

            public void ieteikums()
            {
                //pēc noteiktiem nosacījumiem izlasa no DB ieteikumu un izvada to uz ekrāna
            }
        }
    }
}

