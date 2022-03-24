namespace kilometriKustannukset
{
    partial class kilometrikulut
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.lainaLB = new System.Windows.Forms.Label();
            this.nesteetLB = new System.Windows.Forms.Label();
            this.vakuutusLB = new System.Windows.Forms.Label();
            this.muutLB = new System.Windows.Forms.Label();
            this.pesutLB = new System.Windows.Forms.Label();
            this.huollotLB = new System.Windows.Forms.Label();
            this.renkaatLB = new System.Windows.Forms.Label();
            this.kmLB = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.kilometritCB = new System.Windows.Forms.ComboBox();
            this.lainaTB = new System.Windows.Forms.TextBox();
            this.nesteetTB = new System.Windows.Forms.TextBox();
            this.vakuutusTB = new System.Windows.Forms.TextBox();
            this.muutTB = new System.Windows.Forms.TextBox();
            this.pesutTB = new System.Windows.Forms.TextBox();
            this.huollotTB = new System.Windows.Forms.TextBox();
            this.renkaatTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otsikkoLB.Location = new System.Drawing.Point(177, 55);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(292, 27);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Kilometrikululaskuri";
            // 
            // lainaLB
            // 
            this.lainaLB.AutoSize = true;
            this.lainaLB.Location = new System.Drawing.Point(12, 130);
            this.lainaLB.Name = "lainaLB";
            this.lainaLB.Size = new System.Drawing.Size(218, 23);
            this.lainaLB.TabIndex = 1;
            this.lainaLB.Text = "lainan lyhennys:";
            // 
            // nesteetLB
            // 
            this.nesteetLB.AutoSize = true;
            this.nesteetLB.Location = new System.Drawing.Point(12, 184);
            this.nesteetLB.Name = "nesteetLB";
            this.nesteetLB.Size = new System.Drawing.Size(257, 23);
            this.nesteetLB.TabIndex = 2;
            this.nesteetLB.Text = "lisättävät nesteet:";
            // 
            // vakuutusLB
            // 
            this.vakuutusLB.AutoSize = true;
            this.vakuutusLB.Location = new System.Drawing.Point(12, 235);
            this.vakuutusLB.Name = "vakuutusLB";
            this.vakuutusLB.Size = new System.Drawing.Size(192, 23);
            this.vakuutusLB.TabIndex = 3;
            this.vakuutusLB.Text = "vakuutusmaksu:";
            // 
            // muutLB
            // 
            this.muutLB.AutoSize = true;
            this.muutLB.Location = new System.Drawing.Point(12, 288);
            this.muutLB.Name = "muutLB";
            this.muutLB.Size = new System.Drawing.Size(153, 23);
            this.muutLB.TabIndex = 4;
            this.muutLB.Text = "muut kulut:";
            // 
            // pesutLB
            // 
            this.pesutLB.AutoSize = true;
            this.pesutLB.Location = new System.Drawing.Point(418, 130);
            this.pesutLB.Name = "pesutLB";
            this.pesutLB.Size = new System.Drawing.Size(88, 23);
            this.pesutLB.TabIndex = 5;
            this.pesutLB.Text = "pesut:";
            // 
            // huollotLB
            // 
            this.huollotLB.AutoSize = true;
            this.huollotLB.Location = new System.Drawing.Point(418, 184);
            this.huollotLB.Name = "huollotLB";
            this.huollotLB.Size = new System.Drawing.Size(114, 23);
            this.huollotLB.TabIndex = 6;
            this.huollotLB.Text = "huollot:";
            // 
            // renkaatLB
            // 
            this.renkaatLB.AutoSize = true;
            this.renkaatLB.Location = new System.Drawing.Point(418, 235);
            this.renkaatLB.Name = "renkaatLB";
            this.renkaatLB.Size = new System.Drawing.Size(114, 23);
            this.renkaatLB.TabIndex = 7;
            this.renkaatLB.Text = "renkaat:";
            // 
            // kmLB
            // 
            this.kmLB.AutoSize = true;
            this.kmLB.Location = new System.Drawing.Point(422, 288);
            this.kmLB.Name = "kmLB";
            this.kmLB.Size = new System.Drawing.Size(127, 23);
            this.kmLB.TabIndex = 8;
            this.kmLB.Text = "km/vuosi:";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(12, 359);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(101, 23);
            this.vastausLB.TabIndex = 9;
            this.vastausLB.Text = "vastaus";
            this.vastausLB.Visible = false;
            // 
            // kilometritCB
            // 
            this.kilometritCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.kilometritCB.FormattingEnabled = true;
            this.kilometritCB.Items.AddRange(new object[] {
            "8000",
            "10000",
            "12000",
            "14000",
            "16000",
            "18000",
            "20000",
            "30000"});
            this.kilometritCB.Location = new System.Drawing.Point(555, 288);
            this.kilometritCB.Name = "kilometritCB";
            this.kilometritCB.Size = new System.Drawing.Size(121, 31);
            this.kilometritCB.TabIndex = 10;
            this.kilometritCB.SelectedIndexChanged += new System.EventHandler(this.kilometritCB_SelectedIndexChanged);
            // 
            // lainaTB
            // 
            this.lainaTB.Location = new System.Drawing.Point(266, 127);
            this.lainaTB.Name = "lainaTB";
            this.lainaTB.Size = new System.Drawing.Size(100, 31);
            this.lainaTB.TabIndex = 11;
            // 
            // nesteetTB
            // 
            this.nesteetTB.Location = new System.Drawing.Point(266, 181);
            this.nesteetTB.Name = "nesteetTB";
            this.nesteetTB.Size = new System.Drawing.Size(100, 31);
            this.nesteetTB.TabIndex = 12;
            // 
            // vakuutusTB
            // 
            this.vakuutusTB.Location = new System.Drawing.Point(266, 232);
            this.vakuutusTB.Name = "vakuutusTB";
            this.vakuutusTB.Size = new System.Drawing.Size(100, 31);
            this.vakuutusTB.TabIndex = 13;
            // 
            // muutTB
            // 
            this.muutTB.Location = new System.Drawing.Point(266, 285);
            this.muutTB.Name = "muutTB";
            this.muutTB.Size = new System.Drawing.Size(100, 31);
            this.muutTB.TabIndex = 14;
            // 
            // pesutTB
            // 
            this.pesutTB.Location = new System.Drawing.Point(564, 122);
            this.pesutTB.Name = "pesutTB";
            this.pesutTB.Size = new System.Drawing.Size(100, 31);
            this.pesutTB.TabIndex = 15;
            // 
            // huollotTB
            // 
            this.huollotTB.Location = new System.Drawing.Point(564, 181);
            this.huollotTB.Name = "huollotTB";
            this.huollotTB.Size = new System.Drawing.Size(100, 31);
            this.huollotTB.TabIndex = 16;
            // 
            // renkaatTB
            // 
            this.renkaatTB.Location = new System.Drawing.Point(564, 232);
            this.renkaatTB.Name = "renkaatTB";
            this.renkaatTB.Size = new System.Drawing.Size(100, 31);
            this.renkaatTB.TabIndex = 17;
            // 
            // kilometrikulut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(707, 463);
            this.Controls.Add(this.renkaatTB);
            this.Controls.Add(this.huollotTB);
            this.Controls.Add(this.pesutTB);
            this.Controls.Add(this.muutTB);
            this.Controls.Add(this.vakuutusTB);
            this.Controls.Add(this.nesteetTB);
            this.Controls.Add(this.lainaTB);
            this.Controls.Add(this.kilometritCB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.kmLB);
            this.Controls.Add(this.renkaatLB);
            this.Controls.Add(this.huollotLB);
            this.Controls.Add(this.pesutLB);
            this.Controls.Add(this.muutLB);
            this.Controls.Add(this.vakuutusLB);
            this.Controls.Add(this.nesteetLB);
            this.Controls.Add(this.lainaLB);
            this.Controls.Add(this.otsikkoLB);
            this.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "kilometrikulut";
            this.Text = "Auton todelliset kulut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikkoLB;
        private System.Windows.Forms.Label lainaLB;
        private System.Windows.Forms.Label nesteetLB;
        private System.Windows.Forms.Label vakuutusLB;
        private System.Windows.Forms.Label muutLB;
        private System.Windows.Forms.Label pesutLB;
        private System.Windows.Forms.Label huollotLB;
        private System.Windows.Forms.Label renkaatLB;
        private System.Windows.Forms.Label kmLB;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.ComboBox kilometritCB;
        private System.Windows.Forms.TextBox lainaTB;
        private System.Windows.Forms.TextBox nesteetTB;
        private System.Windows.Forms.TextBox vakuutusTB;
        private System.Windows.Forms.TextBox muutTB;
        private System.Windows.Forms.TextBox pesutTB;
        private System.Windows.Forms.TextBox huollotTB;
        private System.Windows.Forms.TextBox renkaatTB;
    }
}

