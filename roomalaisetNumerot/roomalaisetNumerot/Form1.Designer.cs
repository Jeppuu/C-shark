namespace roomalaisetNumerot
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
            this.numeroLB = new System.Windows.Forms.Label();
            this.numeroTB = new System.Windows.Forms.TextBox();
            this.kaannaBT = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roomalainen numero -kääntäjä";
            // 
            // numeroLB
            // 
            this.numeroLB.AutoSize = true;
            this.numeroLB.Location = new System.Drawing.Point(123, 100);
            this.numeroLB.Name = "numeroLB";
            this.numeroLB.Size = new System.Drawing.Size(297, 25);
            this.numeroLB.TabIndex = 1;
            this.numeroLB.Text = "käännettävä numero (1-3999:";
            // 
            // numeroTB
            // 
            this.numeroTB.BackColor = System.Drawing.Color.Tan;
            this.numeroTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroTB.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.numeroTB.Location = new System.Drawing.Point(128, 128);
            this.numeroTB.Name = "numeroTB";
            this.numeroTB.Size = new System.Drawing.Size(280, 35);
            this.numeroTB.TabIndex = 2;
            this.numeroTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kaannaBT
            // 
            this.kaannaBT.BackColor = System.Drawing.Color.Tan;
            this.kaannaBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.kaannaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaannaBT.Location = new System.Drawing.Point(189, 197);
            this.kaannaBT.Name = "kaannaBT";
            this.kaannaBT.Size = new System.Drawing.Size(142, 40);
            this.kaannaBT.TabIndex = 3;
            this.kaannaBT.Text = "käännä!";
            this.kaannaBT.UseVisualStyleBackColor = false;
            this.kaannaBT.Click += new System.EventHandler(this.kaannaBT_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(123, 279);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(83, 25);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "vastaus";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(595, 381);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.kaannaBT);
            this.Controls.Add(this.numeroTB);
            this.Controls.Add(this.numeroLB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Peru;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numeroLB;
        private System.Windows.Forms.TextBox numeroTB;
        private System.Windows.Forms.Button kaannaBT;
        private System.Windows.Forms.Label vastausLB;
    }
}

