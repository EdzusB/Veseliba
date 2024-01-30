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
    public partial class Datu_apskate : Form
    {
        public Datu_apskate()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();

            if (selectedValue == "fiziska_aktivitate")
            {
                using (SQLiteConnection sqlite_conn = datubazes_konekcija())
                {
                    using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                    {
                        sqlite_cmd.CommandText = "SELECT * FROM fiziska_aktivitate";

                        DataTable sTable = new DataTable();

                        using (SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd))
                        {
                            sqlda.Fill(sTable);
                        }

                        veselibas_dati.DataSource = sTable;
                    }
                }
            }

            else if (selectedValue == "miegs")
            {
                using (SQLiteConnection sqlite_conn = datubazes_konekcija())
                {
                    using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                    {
                        sqlite_cmd.CommandText = "SELECT * FROM miegs";

                        DataTable sTable = new DataTable();

                        using (SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd))
                        {
                            sqlda.Fill(sTable);
                        }

                        veselibas_dati.DataSource = sTable;
                    }
                }
            }

            if (selectedValue == "uzturs")
            {
                using (SQLiteConnection sqlite_conn = datubazes_konekcija())
                {
                    using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                    {
                        sqlite_cmd.CommandText = "SELECT * FROM uzturs";

                        DataTable sTable = new DataTable();

                        using (SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd))
                        {
                            sqlda.Fill(sTable);
                        }

                        veselibas_dati.DataSource = sTable;
                    }
                }
            }

            if (selectedValue == "lietotajs")
            {
                using (SQLiteConnection sqlite_conn = datubazes_konekcija())
                {
                    using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                    {
                        sqlite_cmd.CommandText = "SELECT * FROM lietotajs";

                        DataTable sTable = new DataTable();

                        using (SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd))
                        {
                            sqlda.Fill(sTable);
                        }

                        veselibas_dati.DataSource = sTable;
                    }
                }
            }
        }
    }
}
