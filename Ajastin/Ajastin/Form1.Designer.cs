namespace Ajastin
{
    partial class ajastinForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sekunnitCbx = new System.Windows.Forms.ComboBox();
            this.minuutitCbx = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.ajastinTmr = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timeLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 232);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(261, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sekunnit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(102, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minuutit:";
            // 
            // timeLbl
            // 
            this.timeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Linen;
            this.timeLbl.Location = new System.Drawing.Point(0, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(501, 232);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "00:00";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.sekunnitCbx);
            this.panel2.Controls.Add(this.minuutitCbx);
            this.panel2.Location = new System.Drawing.Point(2, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 90);
            this.panel2.TabIndex = 1;
            // 
            // sekunnitCbx
            // 
            this.sekunnitCbx.BackColor = System.Drawing.Color.Linen;
            this.sekunnitCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sekunnitCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sekunnitCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekunnitCbx.ForeColor = System.Drawing.Color.CadetBlue;
            this.sekunnitCbx.FormattingEnabled = true;
            this.sekunnitCbx.Location = new System.Drawing.Point(263, 26);
            this.sekunnitCbx.Name = "sekunnitCbx";
            this.sekunnitCbx.Size = new System.Drawing.Size(121, 33);
            this.sekunnitCbx.TabIndex = 1;
            // 
            // minuutitCbx
            // 
            this.minuutitCbx.BackColor = System.Drawing.Color.Linen;
            this.minuutitCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuutitCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minuutitCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuutitCbx.ForeColor = System.Drawing.Color.CadetBlue;
            this.minuutitCbx.FormattingEnabled = true;
            this.minuutitCbx.Location = new System.Drawing.Point(100, 26);
            this.minuutitCbx.Name = "minuutitCbx";
            this.minuutitCbx.Size = new System.Drawing.Size(120, 33);
            this.minuutitCbx.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.Linen;
            this.startBtn.Image = global::Ajastin.Properties.Resources.icons8_play_64;
            this.startBtn.Location = new System.Drawing.Point(149, 309);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(73, 65);
            this.startBtn.TabIndex = 2;
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Transparent;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.ForeColor = System.Drawing.Color.Linen;
            this.stopBtn.Image = global::Ajastin.Properties.Resources.icons8_stop_64;
            this.stopBtn.Location = new System.Drawing.Point(265, 309);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(73, 65);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // ajastinTmr
            // 
            this.ajastinTmr.Interval = 1000;
            this.ajastinTmr.Tick += new System.EventHandler(this.ajastinTmr_Tick);
            // 
            // ajastinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Ajastin.Properties.Resources.orange_gradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 394);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ajastinForm";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox sekunnitCbx;
        private System.Windows.Forms.ComboBox minuutitCbx;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Timer ajastinTmr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

