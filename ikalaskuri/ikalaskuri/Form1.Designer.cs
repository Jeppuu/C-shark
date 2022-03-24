namespace ikalaskuri
{
    partial class Ikalaskuri
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
            this.synttaritDT = new System.Windows.Forms.DateTimePicker();
            this.laskeBT = new System.Windows.Forms.Button();
            this.ohje = new System.Windows.Forms.Label();
            this.vuottaLB = new System.Windows.Forms.Label();
            this.kuukauttaLB = new System.Windows.Forms.Label();
            this.paivaaLB = new System.Windows.Forms.Label();
            this.tuntiaLB = new System.Windows.Forms.Label();
            this.minuuttiaLB = new System.Windows.Forms.Label();
            this.sekuntiaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // synttaritDT
            // 
            this.synttaritDT.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.synttaritDT.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.synttaritDT.CalendarTitleBackColor = System.Drawing.Color.RosyBrown;
            this.synttaritDT.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.synttaritDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.synttaritDT.Location = new System.Drawing.Point(41, 85);
            this.synttaritDT.Name = "synttaritDT";
            this.synttaritDT.Size = new System.Drawing.Size(366, 32);
            this.synttaritDT.TabIndex = 0;
            // 
            // laskeBT
            // 
            this.laskeBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.laskeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.laskeBT.Location = new System.Drawing.Point(418, 82);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(103, 35);
            this.laskeBT.TabIndex = 1;
            this.laskeBT.Text = "Laske ikä!";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // ohje
            // 
            this.ohje.AutoSize = true;
            this.ohje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ohje.Location = new System.Drawing.Point(36, 47);
            this.ohje.Name = "ohje";
            this.ohje.Size = new System.Drawing.Size(225, 26);
            this.ohje.TabIndex = 2;
            this.ohje.Text = "Anna syntymäpäiväsi:";
            // 
            // vuottaLB
            // 
            this.vuottaLB.AutoSize = true;
            this.vuottaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.vuottaLB.Location = new System.Drawing.Point(88, 175);
            this.vuottaLB.Name = "vuottaLB";
            this.vuottaLB.Size = new System.Drawing.Size(70, 26);
            this.vuottaLB.TabIndex = 3;
            this.vuottaLB.Text = "label1";
            this.vuottaLB.Visible = false;
            // 
            // kuukauttaLB
            // 
            this.kuukauttaLB.AutoSize = true;
            this.kuukauttaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.kuukauttaLB.Location = new System.Drawing.Point(88, 231);
            this.kuukauttaLB.Name = "kuukauttaLB";
            this.kuukauttaLB.Size = new System.Drawing.Size(70, 26);
            this.kuukauttaLB.TabIndex = 4;
            this.kuukauttaLB.Text = "label2";
            this.kuukauttaLB.Visible = false;
            // 
            // paivaaLB
            // 
            this.paivaaLB.AutoSize = true;
            this.paivaaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.paivaaLB.Location = new System.Drawing.Point(88, 290);
            this.paivaaLB.Name = "paivaaLB";
            this.paivaaLB.Size = new System.Drawing.Size(70, 26);
            this.paivaaLB.TabIndex = 5;
            this.paivaaLB.Text = "label3";
            this.paivaaLB.Visible = false;
            // 
            // tuntiaLB
            // 
            this.tuntiaLB.AutoSize = true;
            this.tuntiaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tuntiaLB.Location = new System.Drawing.Point(337, 175);
            this.tuntiaLB.Name = "tuntiaLB";
            this.tuntiaLB.Size = new System.Drawing.Size(70, 26);
            this.tuntiaLB.TabIndex = 6;
            this.tuntiaLB.Text = "label4";
            this.tuntiaLB.Visible = false;
            // 
            // minuuttiaLB
            // 
            this.minuuttiaLB.AutoSize = true;
            this.minuuttiaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.minuuttiaLB.Location = new System.Drawing.Point(337, 231);
            this.minuuttiaLB.Name = "minuuttiaLB";
            this.minuuttiaLB.Size = new System.Drawing.Size(70, 26);
            this.minuuttiaLB.TabIndex = 7;
            this.minuuttiaLB.Text = "label5";
            this.minuuttiaLB.Visible = false;
            // 
            // sekuntiaLB
            // 
            this.sekuntiaLB.AutoSize = true;
            this.sekuntiaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.sekuntiaLB.Location = new System.Drawing.Point(337, 290);
            this.sekuntiaLB.Name = "sekuntiaLB";
            this.sekuntiaLB.Size = new System.Drawing.Size(70, 26);
            this.sekuntiaLB.TabIndex = 8;
            this.sekuntiaLB.Text = "label6";
            this.sekuntiaLB.Visible = false;
            // 
            // Ikalaskuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(577, 357);
            this.Controls.Add(this.sekuntiaLB);
            this.Controls.Add(this.minuuttiaLB);
            this.Controls.Add(this.tuntiaLB);
            this.Controls.Add(this.paivaaLB);
            this.Controls.Add(this.kuukauttaLB);
            this.Controls.Add(this.vuottaLB);
            this.Controls.Add(this.ohje);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.synttaritDT);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Ikalaskuri";
            this.Text = "ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker synttaritDT;
        private System.Windows.Forms.Button laskeBT;
        private System.Windows.Forms.Label ohje;
        private System.Windows.Forms.Label vuottaLB;
        private System.Windows.Forms.Label kuukauttaLB;
        private System.Windows.Forms.Label paivaaLB;
        private System.Windows.Forms.Label tuntiaLB;
        private System.Windows.Forms.Label minuuttiaLB;
        private System.Windows.Forms.Label sekuntiaLB;
    }
}

