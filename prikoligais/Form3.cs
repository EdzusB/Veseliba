using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace prikoligais
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form3_Load);
        }

        private static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn = null;
            sqlite_conn = new SQLiteConnection("Data Source=datubaze.db; Version = 3; New = True; Compress = True;");

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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Vards_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uzvards_TextChanged(object sender, EventArgs e)
        {

        }

        private void E_pasts_TextChanged(object sender, EventArgs e)
        {

        }

        private void Parole_TextChanged(object sender, EventArgs e)
        {

        }

        private void svars_TextChanged(object sender, EventArgs e)
        {

        }

        private void augums_TextChanged(object sender, EventArgs e)
        {

        }

        private void dzimums_TextChanged(object sender, EventArgs e)
        {

        }

        public class Lietotajs
        {
            private string connectionString;

            public Lietotajs()
            {
            }

            public Lietotajs(string connectionString)
            {
                this.connectionString = connectionString;
            }




            public class lietotajs
            {
                private string connectionString;

                public lietotajs(string connectionString)
                {
                    this.connectionString = connectionString;
                }

                public void IzveidotProfilu(string Vards, string Uzvards, string Parole, string E_pasts, string svars, string augums, string dzimums)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            using (SQLiteCommand command = new SQLiteCommand("INSERT INTO Lietotaji (Vards, Uzvards, E_pasts, Parole, svars, augums, dzimums) VALUES (@Vards, @Uzvards, @E_pasts, @Parole, @svars, @augums, @dzimums)", connection))
                            {
                                command.Parameters.AddWithValue("@Vards", Vards);
                                command.Parameters.AddWithValue("@Uzvards", Uzvards);
                                command.Parameters.AddWithValue("@E_pasts", E_pasts);
                                command.Parameters.AddWithValue("@Parole", Parole);
                                command.Parameters.AddWithValue("@svars", svars);
                                command.Parameters.AddWithValue("@augums", augums);
                                command.Parameters.AddWithValue("@dzimums", dzimums);

                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }

        }

       

        private void Izveidot_profilu_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

