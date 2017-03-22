using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//Za bazu podataka, konekcija, dodano u References
using System.Data.SQLite;

using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Database
    {
        SQLiteCommand m_command = new SQLiteCommand();
        
        String                      fileName;
        String                      connectionString;
        object                      value;
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

        public void Create_Table(String tableName, String definicija)
        {
            // SQL komanda s kojom vidimo jel postoji tablica u bazi
            m_command.Connection      = m_dbConnection;
            m_command.CommandText     = "SELECT name FROM sqlite_master WHERE type='table' AND name='" + tableName + "';";

            value = m_command.ExecuteScalar();
          
            // Ako postoji tablica exists ce biti ime tablice dakle razlicit od null
            if (value == null)
            {
                // Kreira tablicu
                m_command.CommandText = "CREATE TABLE " + tableName + definicija;
                m_command.ExecuteNonQuery();
                
            }
        }

        public DataTable Get_Data(String sql)
        {
            // Lokalna datatable
            DataTable dt = new DataTable();

            try
            {
                // Komandi dajemo konekciju na bazu i sql-komandu koju zelimo izvrsiti nad njom
                m_command.Connection      = m_dbConnection;
                m_command.CommandText     = sql;

                // Reader "cita" tablicu u bazi
                SQLiteDataReader reader = m_command.ExecuteReader();

                // Load funckija datatable-a ucitava podatke iz readera, bez AcceptChanges nece nista ucitati osim imena stupaca i imena tablice
                dt.Load(reader);
                dt.AcceptChanges();
            }
            catch (Exception e)
            {

            }

            // Vraca vrijednost tablice
            return dt;
        }

        public string Get_Single_Data(String sql)
        {
            // Komandi dajemo konekciju na bazu i sql-komandu koju zelimo izvrsiti nad njom
            m_command.Connection      = m_dbConnection;
            m_command.CommandText     = sql;

            value = m_command.ExecuteScalar();

            if(value.ToString() != "")
            {
                return value.ToString();
            }
            
            return "100";
        }

        public bool Insert_Base(String tableName, Dictionary<String, String> data)
        {
            String columns = "";
            String values = "";
            Boolean returnCode = true;
            foreach (KeyValuePair<String, String> val in data)
            {
                columns += String.Format(" {0},", val.Key.ToString());
                values += String.Format(" '{0}',", val.Value);
            }
            columns = columns.Substring(0, columns.Length - 1);
            values = values.Substring(0, values.Length - 1);
            try
            {
                m_command.CommandText = String.Format("insert into {0}({1}) values({2});", tableName, columns, values);
                m_command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                returnCode = false;
            }
            return returnCode;
        }
    }
}
