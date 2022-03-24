namespace lukujenJarjestys
{
    partial class LukujenJarjestys
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
            this.ohjeLB = new System.Windows.Forms.Label();
            this.uusiLukuTB = new System.Windows.Forms.TextBox();
            this.ohje2LB = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ohjeLB
            // 
            this.ohjeLB.AutoSize = true;
            this.ohjeLB.Location = new System.Drawing.Point(12, 89);
            this.ohjeLB.Name = "ohjeLB";
            this.ohjeLB.Size = new System.Drawing.Size(403, 37);
            this.ohjeLB.TabIndex = 0;
            this.ohjeLB.Text = "Syötä haluamasi luku (-999 lopettaaksesi):";
            // 
            // uusiLukuTB
            // 
            this.uusiLukuTB.Location = new System.Drawing.Point(422, 89);
            this.uusiLukuTB.Name = "uusiLukuTB";
            this.uusiLukuTB.Size = new System.Drawing.Size(140, 47);
            this.uusiLukuTB.TabIndex = 1;
            this.uusiLukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uusiLukuTB_KeyPress);
            // 
            // ohje2LB
            // 
            this.ohje2LB.AutoSize = true;
            this.ohje2LB.Location = new System.Drawing.Point(12, 155);
            this.ohje2LB.Name = "ohje2LB";
            this.ohje2LB.Size = new System.Drawing.Size(294, 37);
            this.ohje2LB.TabIndex = 2;
            this.ohje2LB.Text = "Syöttämäsi luvut järjestettynä:";
            this.ohje2LB.Visible = false;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(19, 211);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(47, 37);
            this.vastausLB.TabIndex = 3;
            this.vastausLB.Text = "xxx";
            this.vastausLB.Visible = false;
            // 
            // LukujenJarjestys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(606, 349);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.ohje2LB);
            this.Controls.Add(this.uusiLukuTB);
            this.Controls.Add(this.ohjeLB);
            this.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "LukujenJarjestys";
            this.Text = "Lukujen järjestys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ohjeLB;
        private System.Windows.Forms.TextBox uusiLukuTB;
        private System.Windows.Forms.Label ohje2LB;
        private System.Windows.Forms.Label vastausLB;
    }
}

