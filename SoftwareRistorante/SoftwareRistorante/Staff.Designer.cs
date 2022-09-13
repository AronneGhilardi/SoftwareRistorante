
namespace SoftwareRistorante
{
    partial class Staff
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
            this.Ricerca = new System.Windows.Forms.Button();
            this.Eliminare = new System.Windows.Forms.Button();
            this.Modificare = new System.Windows.Forms.Button();
            this.Aggiungere = new System.Windows.Forms.Button();
            this.Visualizzare = new System.Windows.Forms.Button();
            this.GestioneMenù = new System.Windows.Forms.TextBox();
            this.Recupera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ricerca
            // 
            this.Ricerca.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Ricerca.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ricerca.Location = new System.Drawing.Point(518, 87);
            this.Ricerca.Name = "Ricerca";
            this.Ricerca.Size = new System.Drawing.Size(54, 50);
            this.Ricerca.TabIndex = 12;
            this.Ricerca.Text = "🔍";
            this.Ricerca.UseVisualStyleBackColor = false;
            this.Ricerca.Click += new System.EventHandler(this.Ricerca_Click);
            // 
            // Eliminare
            // 
            this.Eliminare.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Eliminare.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminare.Location = new System.Drawing.Point(297, 143);
            this.Eliminare.Name = "Eliminare";
            this.Eliminare.Size = new System.Drawing.Size(275, 50);
            this.Eliminare.TabIndex = 11;
            this.Eliminare.Text = "Eliminare";
            this.Eliminare.UseVisualStyleBackColor = false;
            this.Eliminare.Click += new System.EventHandler(this.Eliminare_Click);
            // 
            // Modificare
            // 
            this.Modificare.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Modificare.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificare.Location = new System.Drawing.Point(12, 199);
            this.Modificare.Name = "Modificare";
            this.Modificare.Size = new System.Drawing.Size(275, 50);
            this.Modificare.TabIndex = 10;
            this.Modificare.Text = "Modificare";
            this.Modificare.UseVisualStyleBackColor = false;
            this.Modificare.Click += new System.EventHandler(this.Modificare_Click);
            // 
            // Aggiungere
            // 
            this.Aggiungere.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Aggiungere.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aggiungere.Location = new System.Drawing.Point(12, 143);
            this.Aggiungere.Name = "Aggiungere";
            this.Aggiungere.Size = new System.Drawing.Size(275, 50);
            this.Aggiungere.TabIndex = 9;
            this.Aggiungere.Text = "Aggiungere";
            this.Aggiungere.UseVisualStyleBackColor = false;
            this.Aggiungere.Click += new System.EventHandler(this.Aggiungere_Click);
            // 
            // Visualizzare
            // 
            this.Visualizzare.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Visualizzare.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualizzare.Location = new System.Drawing.Point(12, 87);
            this.Visualizzare.Name = "Visualizzare";
            this.Visualizzare.Size = new System.Drawing.Size(500, 50);
            this.Visualizzare.TabIndex = 8;
            this.Visualizzare.Text = "Visualizza Menù";
            this.Visualizzare.UseVisualStyleBackColor = false;
            this.Visualizzare.Click += new System.EventHandler(this.Visualizzare_Click);
            // 
            // GestioneMenù
            // 
            this.GestioneMenù.BackColor = System.Drawing.SystemColors.Menu;
            this.GestioneMenù.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GestioneMenù.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestioneMenù.Location = new System.Drawing.Point(12, 12);
            this.GestioneMenù.Name = "GestioneMenù";
            this.GestioneMenù.Size = new System.Drawing.Size(560, 69);
            this.GestioneMenù.TabIndex = 7;
            this.GestioneMenù.Text = "Gestione Menù";
            this.GestioneMenù.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GestioneMenù.TextChanged += new System.EventHandler(this.GestioneMenù_TextChanged);
            // 
            // Recupera
            // 
            this.Recupera.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Recupera.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recupera.Location = new System.Drawing.Point(297, 199);
            this.Recupera.Name = "Recupera";
            this.Recupera.Size = new System.Drawing.Size(275, 50);
            this.Recupera.TabIndex = 13;
            this.Recupera.Text = "Recupera";
            this.Recupera.UseVisualStyleBackColor = false;
            this.Recupera.Click += new System.EventHandler(this.Recupera_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.Recupera);
            this.Controls.Add(this.Ricerca);
            this.Controls.Add(this.Eliminare);
            this.Controls.Add(this.Modificare);
            this.Controls.Add(this.Aggiungere);
            this.Controls.Add(this.Visualizzare);
            this.Controls.Add(this.GestioneMenù);
            this.Name = "Staff";
            this.Text = "Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ricerca;
        private System.Windows.Forms.Button Eliminare;
        private System.Windows.Forms.Button Modificare;
        private System.Windows.Forms.Button Aggiungere;
        private System.Windows.Forms.Button Visualizzare;
        private System.Windows.Forms.TextBox GestioneMenù;
        private System.Windows.Forms.Button Recupera;
    }
}