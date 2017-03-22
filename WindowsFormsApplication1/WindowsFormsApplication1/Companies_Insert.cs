using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Companies_Insert : Form
    {
        // Treba nam novi objekt baze jer nemamo pristup iz forme1 ako ne posaljemo kao referencu (?)
        Database database = new Database();

        public Companies_Insert()
        {
            InitializeComponent();
        }

        private void Companies_Insert_Load(object sender, EventArgs e)
        {
            // Inicijalizira bazu i ostvaruje konekciju s njom
            database.Initialize();
            database.Connect();

            // Postavlja da se elementi nalaze na cijeloj visini prozora, i polovoci sirine
            Companies_Insert_Table.Height = this.Height;
            Companies_Insert_Table.Width = (this.Width / 2);

            // Uklanja automatsku velicinu po fontu
            ID.AutoSize = false;
            Ime_Firme.AutoSize = false;
            OIB.AutoSize = false;
            Adresa.AutoSize = false;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Pritiskom na esc zatvara prozor
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
