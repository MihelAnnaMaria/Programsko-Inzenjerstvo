namespace WindowsFormsApplication1
{
    partial class Companies_Insert
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
            this.Ime_Firme_Label = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Ime_Firme = new System.Windows.Forms.TextBox();
            this.Title_Panel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.OIB_Label = new System.Windows.Forms.Label();
            this.OIB = new System.Windows.Forms.TextBox();
            this.Adresa_Label = new System.Windows.Forms.Label();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.Companies_Insert_Table = new System.Windows.Forms.TableLayoutPanel();
            this.Title_Panel.SuspendLayout();
            this.Companies_Insert_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ime_Firme_Label
            // 
            this.Ime_Firme_Label.AutoSize = true;
            this.Ime_Firme_Label.BackColor = System.Drawing.Color.Orange;
            this.Companies_Insert_Table.SetColumnSpan(this.Ime_Firme_Label, 10);
            this.Ime_Firme_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ime_Firme_Label.Font = new System.Drawing.Font("High Tower Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime_Firme_Label.Location = new System.Drawing.Point(213, 104);
            this.Ime_Firme_Label.Name = "Ime_Firme_Label";
            this.Ime_Firme_Label.Size = new System.Drawing.Size(204, 52);
            this.Ime_Firme_Label.TabIndex = 0;
            this.Ime_Firme_Label.Text = "Ime Firme:";
            this.Ime_Firme_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.BackColor = System.Drawing.Color.Orange;
            this.Companies_Insert_Table.SetColumnSpan(this.ID_Label, 5);
            this.ID_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ID_Label.Font = new System.Drawing.Font("High Tower Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Label.Location = new System.Drawing.Point(3, 104);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(99, 52);
            this.ID_Label.TabIndex = 1;
            this.ID_Label.Text = "ID:";
            this.ID_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            this.Companies_Insert_Table.SetColumnSpan(this.ID, 5);
            this.ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ID.Font = new System.Drawing.Font("High Tower Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(108, 107);
            this.ID.MaxLength = 3;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(99, 31);
            this.ID.TabIndex = 1;
            // 
            // Ime_Firme
            // 
            this.Companies_Insert_Table.SetColumnSpan(this.Ime_Firme, 30);
            this.Ime_Firme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ime_Firme.Font = new System.Drawing.Font("High Tower Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime_Firme.Location = new System.Drawing.Point(423, 107);
            this.Ime_Firme.MaxLength = 100;
            this.Ime_Firme.Name = "Ime_Firme";
            this.Ime_Firme.Size = new System.Drawing.Size(626, 31);
            this.Ime_Firme.TabIndex = 2;
            // 
            // Title_Panel
            // 
            this.Title_Panel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Companies_Insert_Table.SetColumnSpan(this.Title_Panel, 50);
            this.Title_Panel.Controls.Add(this.Title);
            this.Title_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_Panel.Location = new System.Drawing.Point(3, 3);
            this.Title_Panel.Name = "Title_Panel";
            this.Companies_Insert_Table.SetRowSpan(this.Title_Panel, 2);
            this.Title_Panel.Size = new System.Drawing.Size(1046, 98);
            this.Title_Panel.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("High Tower Text", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Bisque;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1046, 98);
            this.Title.TabIndex = 0;
            this.Title.Text = "       Unos novog korisnika";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OIB_Label
            // 
            this.OIB_Label.AutoSize = true;
            this.OIB_Label.BackColor = System.Drawing.Color.Orange;
            this.Companies_Insert_Table.SetColumnSpan(this.OIB_Label, 5);
            this.OIB_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OIB_Label.Location = new System.Drawing.Point(3, 156);
            this.OIB_Label.Name = "OIB_Label";
            this.OIB_Label.Size = new System.Drawing.Size(99, 52);
            this.OIB_Label.TabIndex = 0;
            this.OIB_Label.Text = "OIB:";
            this.OIB_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OIB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OIB_KeyPress);
            // 
            // OIB
            // 
            this.Companies_Insert_Table.SetColumnSpan(this.OIB, 10);
            this.OIB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OIB.Location = new System.Drawing.Point(108, 159);
            this.OIB.MaxLength = 11;
            this.OIB.Name = "OIB";
            this.OIB.Size = new System.Drawing.Size(204, 31);
            this.OIB.TabIndex = 3;
            // 
            // Adresa_Label
            // 
            this.Adresa_Label.AutoSize = true;
            this.Adresa_Label.BackColor = System.Drawing.Color.Orange;
            this.Companies_Insert_Table.SetColumnSpan(this.Adresa_Label, 7);
            this.Adresa_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Adresa_Label.Location = new System.Drawing.Point(318, 156);
            this.Adresa_Label.Name = "Adresa_Label";
            this.Adresa_Label.Size = new System.Drawing.Size(141, 52);
            this.Adresa_Label.TabIndex = 2;
            this.Adresa_Label.Text = "Adresa:";
            this.Adresa_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Adresa
            // 
            this.Companies_Insert_Table.SetColumnSpan(this.Adresa, 28);
            this.Adresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Adresa.Location = new System.Drawing.Point(465, 159);
            this.Adresa.MaxLength = 100;
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(584, 31);
            this.Adresa.TabIndex = 4;
            // 
            // Companies_Insert_Table
            // 
            this.Companies_Insert_Table.ColumnCount = 50;
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Companies_Insert_Table.Controls.Add(this.Title_Panel, 0, 0);
            this.Companies_Insert_Table.Controls.Add(this.Adresa, 22, 3);
            this.Companies_Insert_Table.Controls.Add(this.ID_Label, 0, 2);
            this.Companies_Insert_Table.Controls.Add(this.OIB, 5, 3);
            this.Companies_Insert_Table.Controls.Add(this.ID, 5, 2);
            this.Companies_Insert_Table.Controls.Add(this.Ime_Firme, 20, 2);
            this.Companies_Insert_Table.Controls.Add(this.OIB_Label, 0, 3);
            this.Companies_Insert_Table.Controls.Add(this.Ime_Firme_Label, 10, 2);
            this.Companies_Insert_Table.Controls.Add(this.Adresa_Label, 15, 3);
            this.Companies_Insert_Table.Dock = System.Windows.Forms.DockStyle.Left;
            this.Companies_Insert_Table.Font = new System.Drawing.Font("High Tower Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Companies_Insert_Table.Location = new System.Drawing.Point(20, 20);
            this.Companies_Insert_Table.Name = "Companies_Insert_Table";
            this.Companies_Insert_Table.RowCount = 20;
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Companies_Insert_Table.Size = new System.Drawing.Size(1052, 1040);
            this.Companies_Insert_Table.TabIndex = 4;
            // 
            // Companies_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Companies_Insert_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Companies_Insert";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.Text = "Companies_Insert";
            this.Load += new System.EventHandler(this.Companies_Insert_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Window_KeyDown);
            this.Title_Panel.ResumeLayout(false);
            this.Companies_Insert_Table.ResumeLayout(false);
            this.Companies_Insert_Table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Title_Panel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Ime_Firme_Label;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Ime_Firme;
        private System.Windows.Forms.Label OIB_Label;
        private System.Windows.Forms.TextBox OIB;
        private System.Windows.Forms.Label Adresa_Label;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.TableLayoutPanel Companies_Insert_Table;
    }
}