namespace nopat
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
            this.noppa1 = new System.Windows.Forms.PictureBox();
            this.noppa2 = new System.Windows.Forms.PictureBox();
            this.buttonHeita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noppa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heitä noppaa";
            // 
            // noppa1
            // 
            this.noppa1.Image = global::nopat.Properties.Resources.dice01;
            this.noppa1.Location = new System.Drawing.Point(12, 81);
            this.noppa1.Name = "noppa1";
            this.noppa1.Size = new System.Drawing.Size(91, 111);
            this.noppa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa1.TabIndex = 1;
            this.noppa1.TabStop = false;
            // 
            // noppa2
            // 
            this.noppa2.Image = global::nopat.Properties.Resources.dice01;
            this.noppa2.Location = new System.Drawing.Point(132, 81);
            this.noppa2.Name = "noppa2";
            this.noppa2.Size = new System.Drawing.Size(91, 111);
            this.noppa2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa2.TabIndex = 2;
            this.noppa2.TabStop = false;
            // 
            // buttonHeita
            // 
            this.buttonHeita.BackColor = System.Drawing.Color.IndianRed;
            this.buttonHeita.FlatAppearance.BorderSize = 0;
            this.buttonHeita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHeita.Location = new System.Drawing.Point(12, 215);
            this.buttonHeita.Name = "buttonHeita";
            this.buttonHeita.Size = new System.Drawing.Size(211, 53);
            this.buttonHeita.TabIndex = 3;
            this.buttonHeita.Text = "Heitä!";
            this.buttonHeita.UseVisualStyleBackColor = false;
            this.buttonHeita.Click += new System.EventHandler(this.buttonHeita_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonHeita;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(235, 299);
            this.Controls.Add(this.buttonHeita);
            this.Controls.Add(this.noppa2);
            this.Controls.Add(this.noppa1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.noppa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox noppa1;
        private System.Windows.Forms.PictureBox noppa2;
        private System.Windows.Forms.Button buttonHeita;
    }
}

