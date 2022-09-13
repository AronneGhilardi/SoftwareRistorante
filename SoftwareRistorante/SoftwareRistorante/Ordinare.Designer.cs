
namespace SoftwareRistorante
{
    partial class Ordinare
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
            this.GestioneMenù = new System.Windows.Forms.TextBox();
            this.Menù = new System.Windows.Forms.ListBox();
            this.Ordine = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GestioneMenù
            // 
            this.GestioneMenù.BackColor = System.Drawing.SystemColors.Menu;
            this.GestioneMenù.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GestioneMenù.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestioneMenù.Location = new System.Drawing.Point(12, 12);
            this.GestioneMenù.Name = "GestioneMenù";
            this.GestioneMenù.Size = new System.Drawing.Size(560, 69);
            this.GestioneMenù.TabIndex = 10;
            this.GestioneMenù.Text = "Menù";
            this.GestioneMenù.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Menù
            // 
            this.Menù.BackColor = System.Drawing.SystemColors.Menu;
            this.Menù.FormattingEnabled = true;
            this.Menù.Location = new System.Drawing.Point(12, 62);
            this.Menù.Name = "Menù";
            this.Menù.Size = new System.Drawing.Size(560, 407);
            this.Menù.TabIndex = 11;
            // 
            // Ordine
            // 
            this.Ordine.BackColor = System.Drawing.SystemColors.Menu;
            this.Ordine.FormattingEnabled = true;
            this.Ordine.Location = new System.Drawing.Point(12, 502);
            this.Ordine.Name = "Ordine";
            this.Ordine.Size = new System.Drawing.Size(560, 199);
            this.Ordine.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ordine:";
            // 
            // button
            // 
            this.button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(12, 707);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(419, 42);
            this.button.TabIndex = 14;
            this.button.Text = "CALCOLA SPESA:";
            this.button.UseVisualStyleBackColor = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(437, 713);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(147, 46);
            this.label.TabIndex = 15;
            this.label.Text = "00,00 Euro";
            // 
            // Ordinare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button);
            this.Controls.Add(this.Ordine);
            this.Controls.Add(this.Menù);
            this.Controls.Add(this.GestioneMenù);
            this.Controls.Add(this.label1);
            this.Name = "Ordinare";
            this.Text = "Ordinare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GestioneMenù;
        private System.Windows.Forms.ListBox Menù;
        private System.Windows.Forms.ListBox Ordine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label;
    }
}