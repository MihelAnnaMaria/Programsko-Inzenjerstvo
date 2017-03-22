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
        Database                        m_database = new Database();
        Dictionary<String, String>      m_unos = new Dictionary<string, string>(); 

        int                 number;
        String              sql;


        public Companies_Insert()
        {
            InitializeComponent();
        }

        private void Companies_Insert_Load(object sender, EventArgs e)
        {
            // Inicijalizira bazu i ostvaruje konekciju s njom
            m_database.Initialize();
            m_database.Connect();

            // Resetira textboxe
            Initialize_Boxes();

            // Postavlja da se elementi nalaze na cijeloj visini prozora, i polovoci sirine
            Companies_Insert_Table.Height = this.Height;
            Companies_Insert_Table.Width = (this.Width / 2);

            // Uklanja automatsku velicinu po fontu
            ID.AutoSize = false;
            Ime_Firme.AutoSize = false;
            OIB.AutoSize = false;
            Adresa.AutoSize = false;
        }

        private void Initialize_Boxes()
        {
            // ID textbox defaultna ("autoincrement") vrijednost
            sql = "SELECT MAX(ID) FROM Companies;";
            number = Convert.ToInt32(m_database.Get_Single_Data(sql));
            ID.Text = (++number).ToString();

            Ime_Firme.Text = "";
            OIB.Text = "";
            Adresa.Text = "";

            m_unos.Remove("ID");
            m_unos.Remove("name");
            m_unos.Remove("OIB");
            m_unos.Remove("adresa");
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Pritiskom na esc zatvara prozor
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            // Pritiskom na enter validira podatke i salje u bazu
            if (e.KeyCode == Keys.Enter)
            {
                // Provjerava da li je sve uneseno
                if(Provjere())
                {
                    Insert_Base();
                }
            }
        }

        private void Insert_Base()
        {
            // Dodaje podatke iz textboxa u Dictionary (key, value) parovi
            m_unos.Add("ID", ID.Text);
            m_unos.Add("name", Ime_Firme.Text);
            m_unos.Add("OIB", OIB.Text);
            m_unos.Add("adresa", Adresa.Text);


            if(m_database.Insert_Base("Companies", m_unos))
            {
                MessageBox.Show("Uspjesno uneseno u bazu!");
                Initialize_Boxes();
            }
            else
            {
                MessageBox.Show("Pogreška prilikom unosa, probajte ponovo!");
                Initialize_Boxes();
            }
        }

        private void OIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ne dopusta unos bilo cega osim brojeva u OIB textbox
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private bool Provjere()
        {
            if (Ime_Firme.Text.Length < 1)
            {
                MessageBox.Show("Unesite ime firme!");
                return false;
            }
            if (OIB.Text.Length < OIB.MaxLength)
            {
                MessageBox.Show("Unesite ispravan OIB!");
                return false;
            }
            if(Adresa.Text.Length < 1)
            {
                MessageBox.Show("Unesite adresu!");
                return false;
            }

            return true;
        }
    }
}
