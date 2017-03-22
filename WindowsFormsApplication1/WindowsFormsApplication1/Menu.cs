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
    public partial class Window : Form
    {
        Companies_Insert    m_companies_Insert  = new Companies_Insert();
        Database            m_database          = new Database();
        Tables              m_tables            = new Tables();
        DataTable           m_datatable         = new DataTable();

        private String                  sql;
        private bool                    mouseDown;
        private Point                   lastLocation;
          

        public Window()
        {
            // Inicijalizira sve komponente na prozoru
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            // Uklanja border, dakle nema one trake sa minimize, maximize i exit
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // Inicijalizacija baze i spajanje
            m_database.Initialize();
            m_database.Connect();

            // Inicijalizacija tablica
            m_tables.Initialize_Tables(m_database);

            // Popunjava listu firmi pri prvom pokretanju programa
            Update_List();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Gumb za exit
            Application.Exit();
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            // Ako stisnemo lijevi klik daje lokaciju pointera
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            // Dok je stisnut lijevi klik i dok pomicemo racuna novu poziciju pointera
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                // Updatea lokaciju prozora na ekranu
                this.Update();
            }
        }

        private void Window_MouseUp(object sender, MouseEventArgs e)
        {
            // Bez ovoga bi zauvijek micali prozor po ekranu
            mouseDown = false;
        }

        private void Dodaj_Novog_Click(object sender, EventArgs e)
        {
            // Otvara novi prozor kao modal, Companies_Insert.cs
            m_companies_Insert.ShowDialog();

            // Kad se zatvori update-a listu firmi
            Update_List();
        }

        private void Update_List()
        {
            // Sql za odabiranje svih firmi iz baze, poziva metodu iz database.cs i popunjava datatable
            sql = "SELECT * FROM Companies;";
            m_datatable = m_database.Get_Data(sql);

            // Listboxu kao source podataka daje datatable, ono sto vidimo = name, a kao vrijednost dobijemo ID
            Firme_Lista.DataSource = m_datatable;
            Firme_Lista.DisplayMember = "name";
            Firme_Lista.ValueMember = "ID";
        }
    }
}
