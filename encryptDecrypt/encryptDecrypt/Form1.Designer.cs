namespace encryptDecrypt
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.salasanaTbx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cryptaaBtn = new System.Windows.Forms.Button();
            this.naytaSalasanaBtn = new System.Windows.Forms.Button();
            this.vastausLbl = new System.Windows.Forms.Label();
            this.CryptattuCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "salasana:";
            // 
            // salasanaTbx
            // 
            this.salasanaTbx.BackColor = System.Drawing.Color.Black;
            this.salasanaTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salasanaTbx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.salasanaTbx.Location = new System.Drawing.Point(64, 70);
            this.salasanaTbx.Name = "salasanaTbx";
            this.salasanaTbx.Size = new System.Drawing.Size(182, 23);
            this.salasanaTbx.TabIndex = 2;
            this.salasanaTbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TyhjennaVastaus);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Location = new System.Drawing.Point(64, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 5);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "cryptattu:";
            // 
            // cryptaaBtn
            // 
            this.cryptaaBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cryptaaBtn.FlatAppearance.BorderSize = 0;
            this.cryptaaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cryptaaBtn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cryptaaBtn.ForeColor = System.Drawing.Color.Black;
            this.cryptaaBtn.Location = new System.Drawing.Point(64, 118);
            this.cryptaaBtn.Name = "cryptaaBtn";
            this.cryptaaBtn.Size = new System.Drawing.Size(182, 35);
            this.cryptaaBtn.TabIndex = 7;
            this.cryptaaBtn.Text = "Cryptaa";
            this.cryptaaBtn.UseVisualStyleBackColor = false;
            this.cryptaaBtn.Click += new System.EventHandler(this.cryptaaBtn_Click);
            // 
            // naytaSalasanaBtn
            // 
            this.naytaSalasanaBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.naytaSalasanaBtn.FlatAppearance.BorderSize = 0;
            this.naytaSalasanaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naytaSalasanaBtn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naytaSalasanaBtn.ForeColor = System.Drawing.Color.Black;
            this.naytaSalasanaBtn.Location = new System.Drawing.Point(360, 118);
            this.naytaSalasanaBtn.Name = "naytaSalasanaBtn";
            this.naytaSalasanaBtn.Size = new System.Drawing.Size(182, 35);
            this.naytaSalasanaBtn.TabIndex = 8;
            this.naytaSalasanaBtn.Text = "Decryptaa";
            this.naytaSalasanaBtn.UseVisualStyleBackColor = false;
            this.naytaSalasanaBtn.Click += new System.EventHandler(this.naytaSalasanaBtn_Click);
            // 
            // vastausLbl
            // 
            this.vastausLbl.Location = new System.Drawing.Point(127, 198);
            this.vastausLbl.Name = "vastausLbl";
            this.vastausLbl.Size = new System.Drawing.Size(325, 76);
            this.vastausLbl.TabIndex = 9;
            this.vastausLbl.Text = "vastaus";
            this.vastausLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vastausLbl.Visible = false;
            // 
            // CryptattuCbx
            // 
            this.CryptattuCbx.BackColor = System.Drawing.Color.Black;
            this.CryptattuCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CryptattuCbx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CryptattuCbx.FormattingEnabled = true;
            this.CryptattuCbx.Location = new System.Drawing.Point(360, 67);
            this.CryptattuCbx.Name = "CryptattuCbx";
            this.CryptattuCbx.Size = new System.Drawing.Size(183, 33);
            this.CryptattuCbx.TabIndex = 10;
            this.CryptattuCbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CryptattuCbx_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(582, 302);
            this.Controls.Add(this.CryptattuCbx);
            this.Controls.Add(this.vastausLbl);
            this.Controls.Add(this.naytaSalasanaBtn);
            this.Controls.Add(this.cryptaaBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.salasanaTbx);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Encrypt & Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salasanaTbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cryptaaBtn;
        private System.Windows.Forms.Button naytaSalasanaBtn;
        private System.Windows.Forms.Label vastausLbl;
        private System.Windows.Forms.ComboBox CryptattuCbx;
    }
}

