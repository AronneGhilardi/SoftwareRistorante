
namespace SoftwareRistorante
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.TRATTORIAdaKEKKO = new System.Windows.Forms.TextBox();
            this.Cliente = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TRATTORIAdaKEKKO
            // 
            this.TRATTORIAdaKEKKO.BackColor = System.Drawing.SystemColors.Menu;
            this.TRATTORIAdaKEKKO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TRATTORIAdaKEKKO.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRATTORIAdaKEKKO.Location = new System.Drawing.Point(12, 12);
            this.TRATTORIAdaKEKKO.Name = "TRATTORIAdaKEKKO";
            this.TRATTORIAdaKEKKO.Size = new System.Drawing.Size(560, 69);
            this.TRATTORIAdaKEKKO.TabIndex = 0;
            this.TRATTORIAdaKEKKO.Text = "TRATTORIA da KEKKO";
            this.TRATTORIAdaKEKKO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cliente.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Cliente.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(12, 87);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(560, 42);
            this.Cliente.TabIndex = 1;
            this.Cliente.Text = "- ORDINA ORA -";
            this.Cliente.UseVisualStyleBackColor = false;
            this.Cliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // Login
            // 
            this.Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Login.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(476, 196);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(96, 30);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.Location = new System.Drawing.Point(8, 196);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(101, 34);
            this.PasswordText.TabIndex = 5;
            this.PasswordText.Text = "Password:";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Menu;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(105, 196);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(365, 30);
            this.Password.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Area STAFF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.TRATTORIAdaKEKKO);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TRATTORIAdaKEKKO;
        private System.Windows.Forms.Button Cliente;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
    }
}

