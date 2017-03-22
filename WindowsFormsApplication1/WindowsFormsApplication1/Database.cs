﻿using System;
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
        SQLiteCommand command       = new SQLiteCommand();
        
        String                      fileName;
        String                      connectionString;
        object                      exists;
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
            command.Connection      = m_dbConnection;
            command.CommandText     = "SELECT name FROM sqlite_master WHERE type='table' AND name='" + tableName + "';";

            exists = command.ExecuteScalar();
          
            // Ako postoji tablica exists ce biti ime tablice dakle razlicit od null
            if (exists == null)
            {
                // Kreira tablicu
                command.CommandText = "CREATE TABLE " + tableName + definicija;
                command.ExecuteNonQuery();
                
            }
        }

        public DataTable Get_Data(String sql)
        {
            // Lokalna datatable
            DataTable dt = new DataTable();

            try
            {
                // Komandi dajemo konekciju na bazu i sql-komandu koju zelimo izvrsiti nad njom
                command.Connection      = m_dbConnection;
                command.CommandText     = sql;

                // Reader "cita" tablicu u bazi
                SQLiteDataReader reader = command.ExecuteReader();

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
    }
}
