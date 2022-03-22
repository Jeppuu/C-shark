namespace SalasananTarkastus
{
    partial class SalasanaForm
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
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.tarkistaBT = new System.Windows.Forms.Button();
            this.virheLB = new System.Windows.Forms.Label();
            this.salasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SalasanaPanel.SuspendLayout();
            this.salasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPanel.Controls.Add(this.virheLB);
            this.SalasanaPanel.Controls.Add(this.tarkistaBT);
            this.SalasanaPanel.Controls.Add(this.salasanaTB);
            this.SalasanaPanel.Controls.Add(this.kayttajaTB);
            this.SalasanaPanel.Controls.Add(this.label2);
            this.SalasanaPanel.Controls.Add(this.label1);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(330, 370);
            this.SalasanaPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(56, 94);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(199, 35);
            this.kayttajaTB.TabIndex = 2;
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(56, 191);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(199, 35);
            this.salasanaTB.TabIndex = 3;
            // 
            // tarkistaBT
            // 
            this.tarkistaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tarkistaBT.Location = new System.Drawing.Point(56, 266);
            this.tarkistaBT.Name = "tarkistaBT";
            this.tarkistaBT.Size = new System.Drawing.Size(199, 42);
            this.tarkistaBT.TabIndex = 4;
            this.tarkistaBT.Text = "Tarkista";
            this.tarkistaBT.UseVisualStyleBackColor = true;
            this.tarkistaBT.Click += new System.EventHandler(this.tarkistaBT_Click);
            // 
            // virheLB
            // 
            this.virheLB.AutoSize = true;
            this.virheLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virheLB.ForeColor = System.Drawing.Color.Red;
            this.virheLB.Location = new System.Drawing.Point(42, 323);
            this.virheLB.Name = "virheLB";
            this.virheLB.Size = new System.Drawing.Size(109, 25);
            this.virheLB.TabIndex = 5;
            this.virheLB.Text = "virheviesti";
            this.virheLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.virheLB.Visible = false;
            // 
            // salasanaOikeinPanel
            // 
            this.salasanaOikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.salasanaOikeinPanel.Controls.Add(this.label4);
            this.salasanaOikeinPanel.Controls.Add(this.label3);
            this.salasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaOikeinPanel.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaOikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.salasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.salasanaOikeinPanel.Name = "salasanaOikeinPanel";
            this.salasanaOikeinPanel.Size = new System.Drawing.Size(330, 370);
            this.salasanaOikeinPanel.TabIndex = 1;
            this.salasanaOikeinPanel.Visible = false;
            this.salasanaOikeinPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.salasanaOikeinPanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 80);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 80);
            this.label4.TabIndex = 1;
            this.label4.Text = "sivuilleni!";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 370);
            this.Controls.Add(this.salasanaOikeinPanel);
            this.Controls.Add(this.SalasanaPanel);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkastus";
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.salasanaOikeinPanel.ResumeLayout(false);
            this.salasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SalasanaPanel;
        private System.Windows.Forms.Label virheLB;
        private System.Windows.Forms.Button tarkistaBT;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.TextBox kayttajaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel salasanaOikeinPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

