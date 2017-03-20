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
        Database    database        = new Database();
        Tables      tables          = new Tables();

        private bool                    mouseDown;
        private Point                   lastLocation;
          

        public Window()
        {
            // Inicijalizira sve komponente na prozoru
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            // Ukljanja border, dakle nema one trake sa minimize, maximize i exit
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //Inicijalizacija baze i spajanje
            database.Initialize();
            database.Connect();

            //Inicijalizacija tablica
            tables.Initialize_Tables(database);

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
    }
}
