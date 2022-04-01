namespace BMIlaskuri
{
    partial class BMIlaskuri
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pituusTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vastausLB = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 105);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(172, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laske oma painoindeksisi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pituusTB
            // 
            this.pituusTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pituusTB.BackColor = System.Drawing.Color.Gainsboro;
            this.pituusTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pituusTB.Location = new System.Drawing.Point(160, 169);
            this.pituusTB.Multiline = false;
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.pituusTB.Size = new System.Drawing.Size(374, 47);
            this.pituusTB.TabIndex = 2;
            this.pituusTB.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(160, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pituutesi (cm):";
            // 
            // painoTB
            // 
            this.painoTB.BackColor = System.Drawing.Color.Gainsboro;
            this.painoTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.painoTB.Location = new System.Drawing.Point(160, 276);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(374, 47);
            this.painoTB.TabIndex = 4;
            this.painoTB.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(160, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Painosi (kg):";
            // 
            // LaskeBT
            // 
            this.LaskeBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LaskeBT.FlatAppearance.BorderSize = 0;
            this.LaskeBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.LaskeBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaskeBT.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskeBT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LaskeBT.Image = global::BMIlaskuri.Properties.Resources.icons8_arrow_26;
            this.LaskeBT.Location = new System.Drawing.Point(266, 341);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(122, 83);
            this.LaskeBT.TabIndex = 6;
            this.LaskeBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LaskeBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.vastausLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 105);
            this.panel1.TabIndex = 7;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausLB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vastausLB.Location = new System.Drawing.Point(127, 20);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(232, 30);
            this.vastausLB.TabIndex = 0;
            this.vastausLB.Text = "vastaus vastaus vastaus";
            this.vastausLB.Visible = false;
            // 
            // BMIlaskuri
            // 
            this.AcceptButton = this.LaskeBT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(687, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BMIlaskuri";
            this.Text = "BMI laskuri";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox pituusTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox painoTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LaskeBT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label vastausLB;
    }
}

