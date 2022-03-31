namespace CelsiusFarenheitMuunnin
{
    partial class CFMuunnin
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
            this.asteetTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CtoF = new System.Windows.Forms.RadioButton();
            this.FtoC = new System.Windows.Forms.RadioButton();
            this.button = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius - Fahrenheit muuntaja";
            // 
            // asteetTB
            // 
            this.asteetTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.asteetTB.Location = new System.Drawing.Point(72, 155);
            this.asteetTB.Name = "asteetTB";
            this.asteetTB.Size = new System.Drawing.Size(264, 35);
            this.asteetTB.TabIndex = 1;
            this.asteetTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anna asteet:";
            // 
            // CtoF
            // 
            this.CtoF.AutoSize = true;
            this.CtoF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtoF.Location = new System.Drawing.Point(72, 209);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(221, 29);
            this.CtoF.TabIndex = 3;
            this.CtoF.TabStop = true;
            this.CtoF.Text = "celsiusta fahrenheitiksi";
            this.CtoF.UseVisualStyleBackColor = true;
            // 
            // FtoC
            // 
            this.FtoC.AutoSize = true;
            this.FtoC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FtoC.Location = new System.Drawing.Point(72, 244);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(240, 29);
            this.FtoC.TabIndex = 4;
            this.FtoC.TabStop = true;
            this.FtoC.Text = "fahrenheittia celsiukseksi";
            this.FtoC.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Black;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(72, 304);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(264, 48);
            this.button.TabIndex = 5;
            this.button.Text = "Muunna!";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(36, 393);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(82, 30);
            this.vastausLB.TabIndex = 6;
            this.vastausLB.Text = "vastaus";
            this.vastausLB.Visible = false;
            // 
            // CFMuunnin
            // 
            this.AcceptButton = this.button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 500);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.button);
            this.Controls.Add(this.FtoC);
            this.Controls.Add(this.CtoF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asteetTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CFMuunnin";
            this.ShowIcon = false;
            this.Text = "Celsius Fahrenheit muunnin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox asteetTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton CtoF;
        private System.Windows.Forms.RadioButton FtoC;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label vastausLB;
    }
}

