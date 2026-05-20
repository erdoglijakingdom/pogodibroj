namespace WindowsFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.Button btnProveri;
        private System.Windows.Forms.Label lblUnesibroj;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Label lblPokusaji;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.btnProveri = new System.Windows.Forms.Button();
            this.lblUnesibroj = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.lblPokusaji = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtBroj
            this.txtBroj.Location = new System.Drawing.Point(220, 100);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(80, 20);
            this.txtBroj.TabIndex = 0;

            // btnProveri
            this.btnProveri.Location = new System.Drawing.Point(310, 98);
            this.btnProveri.Name = "btnProveri";
            this.btnProveri.Size = new System.Drawing.Size(75, 23);
            this.btnProveri.Text = "Proveri";
            this.btnProveri.TabIndex = 1;
            this.btnProveri.Click += new System.EventHandler(this.btnProveri_Click);

            // lblUnesibroj
            this.lblUnesibroj.AutoSize = true;
            this.lblUnesibroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUnesibroj.Location = new System.Drawing.Point(130, 103);
            this.lblUnesibroj.Name = "lblUnesibroj";
            this.lblUnesibroj.Text = "Unesi broj";

            // lblRezultat
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRezultat.Location = new System.Drawing.Point(130, 160);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Text = "Rezultat";

            // lblPokusaji
            this.lblPokusaji.AutoSize = true;
            this.lblPokusaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPokusaji.Location = new System.Drawing.Point(130, 205);
            this.lblPokusaji.Name = "lblPokusaji";
            this.lblPokusaji.Text = "Broj pokušaja";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.btnProveri);
            this.Controls.Add(this.lblUnesibroj);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblPokusaji);
            this.Name = "Form1";
            this.Text = "Pogadjanje broja";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}