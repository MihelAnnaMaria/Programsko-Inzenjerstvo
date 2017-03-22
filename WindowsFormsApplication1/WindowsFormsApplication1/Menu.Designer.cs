namespace WindowsFormsApplication1
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Dodaj_Novog = new System.Windows.Forms.Button();
            this.Menu_Table = new System.Windows.Forms.TableLayoutPanel();
            this.Firme_Lista = new System.Windows.Forms.ListBox();
            this.Menu_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            resources.ApplyResources(this.MenuPanel, "MenuPanel");
            this.MenuPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MenuPanel.Name = "MenuPanel";
            this.Menu_Table.SetRowSpan(this.MenuPanel, 7);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Dodaj_Novog
            // 
            this.Dodaj_Novog.BackColor = System.Drawing.Color.Orange;
            this.Dodaj_Novog.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Dodaj_Novog, "Dodaj_Novog");
            this.Dodaj_Novog.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.Dodaj_Novog.Name = "Dodaj_Novog";
            this.Dodaj_Novog.UseVisualStyleBackColor = false;
            this.Dodaj_Novog.Click += new System.EventHandler(this.Dodaj_Novog_Click);
            // 
            // Menu_Table
            // 
            resources.ApplyResources(this.Menu_Table, "Menu_Table");
            this.Menu_Table.Controls.Add(this.MenuPanel, 0, 0);
            this.Menu_Table.Controls.Add(this.Dodaj_Novog, 3, 0);
            this.Menu_Table.Controls.Add(this.ExitButton, 3, 6);
            this.Menu_Table.Controls.Add(this.Firme_Lista, 1, 0);
            this.Menu_Table.Name = "Menu_Table";
            this.Menu_Table.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            this.Menu_Table.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_MouseMove);
            this.Menu_Table.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Window_MouseUp);
            // 
            // Firme_Lista
            // 
            this.Menu_Table.SetColumnSpan(this.Firme_Lista, 2);
            resources.ApplyResources(this.Firme_Lista, "Firme_Lista");
            this.Firme_Lista.FormattingEnabled = true;
            this.Firme_Lista.Name = "Firme_Lista";
            this.Firme_Lista.Sorted = true;
            // 
            // Window
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ControlBox = false;
            this.Controls.Add(this.Menu_Table);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Window";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Window_Load);
            this.Menu_Table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Dodaj_Novog;
        private System.Windows.Forms.TableLayoutPanel Menu_Table;
        private System.Windows.Forms.ListBox Firme_Lista;
    }
}

