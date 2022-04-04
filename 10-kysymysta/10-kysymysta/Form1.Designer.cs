namespace _10_kysymysta
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
            this.labelVastaus = new System.Windows.Forms.Label();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.Dummy = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.labelOikein = new System.Windows.Forms.Label();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelVastaus
            // 
            this.labelVastaus.AutoSize = true;
            this.labelVastaus.Location = new System.Drawing.Point(30, 27);
            this.labelVastaus.Name = "labelVastaus";
            this.labelVastaus.Size = new System.Drawing.Size(182, 20);
            this.labelVastaus.TabIndex = 0;
            this.labelVastaus.Text = "vastaus 1. kysymykseen:";
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(49, 64);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(38, 24);
            this.radioButtonA.TabIndex = 1;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // Dummy
            // 
            this.Dummy.AutoCheck = false;
            this.Dummy.AutoSize = true;
            this.Dummy.Location = new System.Drawing.Point(49, 64);
            this.Dummy.Name = "Dummy";
            this.Dummy.Size = new System.Drawing.Size(38, 24);
            this.Dummy.TabIndex = 0;
            this.Dummy.TabStop = true;
            this.Dummy.Text = "E";
            this.Dummy.UseVisualStyleBackColor = true;
            this.Dummy.Visible = false;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(49, 124);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(38, 24);
            this.radioButtonC.TabIndex = 3;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(49, 94);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(38, 24);
            this.radioButtonB.TabIndex = 2;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // labelOikein
            // 
            this.labelOikein.AutoSize = true;
            this.labelOikein.Location = new System.Drawing.Point(30, 196);
            this.labelOikein.Name = "labelOikein";
            this.labelOikein.Size = new System.Drawing.Size(156, 20);
            this.labelOikein.TabIndex = 4;
            this.labelOikein.Text = "Oikeita vastauksia oli";
            this.labelOikein.Visible = false;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(49, 154);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(39, 24);
            this.radioButtonD.TabIndex = 4;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(234, 233);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.labelOikein);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.Dummy);
            this.Controls.Add(this.labelVastaus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "10 kysymystä";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVastaus;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton Dummy;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.Label labelOikein;
        private System.Windows.Forms.RadioButton radioButtonD;
    }
}

