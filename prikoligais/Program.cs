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
using prikoligais;

namespace Sporta_Aplikacija_OL2
{
    class Program
    {
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

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }


}
