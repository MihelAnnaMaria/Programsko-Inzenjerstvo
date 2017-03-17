using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Za bazu podataka, konekcija, dodano u References
using System.Data.SQLite;

//MessageBox
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Connection
    {
        string                      fileName;
        string                      sql;
        string                      connectionString;
        SQLiteConnection            m_dbConnection;


        public void Initialize()
        {
            // Dohvaca lokaciju file-a relativno o lokaciji projekta (bin > Debug > )
            fileName = (Path.Combine(Environment.CurrentDirectory, "database.db"));
        }

        public void Connect()
        {

            // Provjera da li baza postoji
            if (!File.Exists(fileName))
            {
                // Ako ne postoji kreiraj novu
                SQLiteConnection.CreateFile(fileName);
            }

            // Ako postoji spoji se sa njom
            connectionString = @"Data Source=" + fileName + ";Version=3;";
            m_dbConnection = new SQLiteConnection(connectionString);
            m_dbConnection.Open();
        }
    }
}
