using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Tables
    {
        // Polje stringova za kreiranje tablica, ime tablice pa definicija tablice
        string[] sql = new String[]
        {
            "Companies",
            "(ID INT NOT NULL PRIMARY KEY, name VARCHAR(100) NOT NULL, OIB INT NOT NULL, adresa VARCHAR(100) NOT NULL);",
        };


        public void Initialize_Tables(Database database)
        {
            // Prolazi kroz polje i poziva funkciju iz Database.cs za kreiranje tablica
            for(int i = 0; i < sql.Length; i+=2)
            {
                database.Create_Table(sql[i], sql[i+1]);
            }
        }
    }
}
