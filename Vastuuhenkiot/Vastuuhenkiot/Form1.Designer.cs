namespace Vastuuhenkiot
{
    partial class vastuuhenkilotForm
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
            this.otsikkoPanel = new System.Windows.Forms.Panel();
            this.oppilaitosLbl = new System.Windows.Forms.Label();
            this.oppilaitosCbx = new System.Windows.Forms.ComboBox();
            this.vastuuhenkCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.osoiteLbl = new System.Windows.Forms.Label();
            this.pnroLbl = new System.Windows.Forms.Label();
            this.ptoimipaikkaLbl = new System.Windows.Forms.Label();
            this.OpuhelinLbl = new System.Windows.Forms.Label();
            this.VpuhelinLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.osastoLbl = new System.Windows.Forms.Label();
            this.titteliLbl = new System.Windows.Forms.Label();
            this.otsikkoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // otsikkoPanel
            // 
            this.otsikkoPanel.BackColor = System.Drawing.Color.Transparent;
            this.otsikkoPanel.Controls.Add(this.label1);
            this.otsikkoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.otsikkoPanel.Location = new System.Drawing.Point(0, 0);
            this.otsikkoPanel.Name = "otsikkoPanel";
            this.otsikkoPanel.Size = new System.Drawing.Size(658, 61);
            this.otsikkoPanel.TabIndex = 1;
            // 
            // oppilaitosLbl
            // 
            this.oppilaitosLbl.AutoSize = true;
            this.oppilaitosLbl.Location = new System.Drawing.Point(81, 82);
            this.oppilaitosLbl.Name = "oppilaitosLbl";
            this.oppilaitosLbl.Size = new System.Drawing.Size(110, 25);
            this.oppilaitosLbl.TabIndex = 2;
            this.oppilaitosLbl.Text = "Oppilaitos:";
            // 
            // oppilaitosCbx
            // 
            this.oppilaitosCbx.FormattingEnabled = true;
            this.oppilaitosCbx.Location = new System.Drawing.Point(81, 110);
            this.oppilaitosCbx.Name = "oppilaitosCbx";
            this.oppilaitosCbx.Size = new System.Drawing.Size(135, 33);
            this.oppilaitosCbx.TabIndex = 3;
            this.oppilaitosCbx.SelectedIndexChanged += new System.EventHandler(this.oppilaitosCbx_SelectedIndexChanged);
            // 
            // vastuuhenkCbx
            // 
            this.vastuuhenkCbx.FormattingEnabled = true;
            this.vastuuhenkCbx.Location = new System.Drawing.Point(340, 110);
            this.vastuuhenkCbx.Name = "vastuuhenkCbx";
            this.vastuuhenkCbx.Size = new System.Drawing.Size(206, 33);
            this.vastuuhenkCbx.TabIndex = 5;
            this.vastuuhenkCbx.TextChanged += new System.EventHandler(this.vastuuhenkCbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vastuuhenkilö:";
            // 
            // osoiteLbl
            // 
            this.osoiteLbl.AutoSize = true;
            this.osoiteLbl.Location = new System.Drawing.Point(85, 194);
            this.osoiteLbl.Name = "osoiteLbl";
            this.osoiteLbl.Size = new System.Drawing.Size(68, 25);
            this.osoiteLbl.TabIndex = 6;
            this.osoiteLbl.Text = "osoite";
            // 
            // pnroLbl
            // 
            this.pnroLbl.AutoSize = true;
            this.pnroLbl.Location = new System.Drawing.Point(85, 237);
            this.pnroLbl.Name = "pnroLbl";
            this.pnroLbl.Size = new System.Drawing.Size(129, 25);
            this.pnroLbl.TabIndex = 7;
            this.pnroLbl.Text = "postinumero";
            // 
            // ptoimipaikkaLbl
            // 
            this.ptoimipaikkaLbl.AutoSize = true;
            this.ptoimipaikkaLbl.Location = new System.Drawing.Point(85, 280);
            this.ptoimipaikkaLbl.Name = "ptoimipaikkaLbl";
            this.ptoimipaikkaLbl.Size = new System.Drawing.Size(163, 25);
            this.ptoimipaikkaLbl.TabIndex = 8;
            this.ptoimipaikkaLbl.Text = "postitoimipaikka";
            // 
            // OpuhelinLbl
            // 
            this.OpuhelinLbl.AutoSize = true;
            this.OpuhelinLbl.Location = new System.Drawing.Point(85, 323);
            this.OpuhelinLbl.Name = "OpuhelinLbl";
            this.OpuhelinLbl.Size = new System.Drawing.Size(153, 25);
            this.OpuhelinLbl.TabIndex = 9;
            this.OpuhelinLbl.Text = "puhelinnumero";
            // 
            // VpuhelinLbl
            // 
            this.VpuhelinLbl.AutoSize = true;
            this.VpuhelinLbl.Location = new System.Drawing.Point(349, 323);
            this.VpuhelinLbl.Name = "VpuhelinLbl";
            this.VpuhelinLbl.Size = new System.Drawing.Size(153, 25);
            this.VpuhelinLbl.TabIndex = 13;
            this.VpuhelinLbl.Text = "puhelinnumero";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(349, 280);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(62, 25);
            this.emailLbl.TabIndex = 12;
            this.emailLbl.Text = "email";
            // 
            // osastoLbl
            // 
            this.osastoLbl.AutoSize = true;
            this.osastoLbl.Location = new System.Drawing.Point(349, 237);
            this.osastoLbl.Name = "osastoLbl";
            this.osastoLbl.Size = new System.Drawing.Size(72, 25);
            this.osastoLbl.TabIndex = 11;
            this.osastoLbl.Text = "osasto";
            // 
            // titteliLbl
            // 
            this.titteliLbl.AutoSize = true;
            this.titteliLbl.Location = new System.Drawing.Point(349, 194);
            this.titteliLbl.Name = "titteliLbl";
            this.titteliLbl.Size = new System.Drawing.Size(59, 25);
            this.titteliLbl.TabIndex = 10;
            this.titteliLbl.Text = "titteli";
            // 
            // vastuuhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(658, 405);
            this.Controls.Add(this.VpuhelinLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.osastoLbl);
            this.Controls.Add(this.titteliLbl);
            this.Controls.Add(this.OpuhelinLbl);
            this.Controls.Add(this.ptoimipaikkaLbl);
            this.Controls.Add(this.pnroLbl);
            this.Controls.Add(this.osoiteLbl);
            this.Controls.Add(this.vastuuhenkCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oppilaitosCbx);
            this.Controls.Add(this.oppilaitosLbl);
            this.Controls.Add(this.otsikkoPanel);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "vastuuhenkilotForm";
            this.Text = "Oppilaitosten vastuuhenkilöt";
            this.Load += new System.EventHandler(this.vastuuhenkilotForm_Load);
            this.otsikkoPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel otsikkoPanel;
        private System.Windows.Forms.Label oppilaitosLbl;
        private System.Windows.Forms.ComboBox oppilaitosCbx;
        private System.Windows.Forms.ComboBox vastuuhenkCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label osoiteLbl;
        private System.Windows.Forms.Label pnroLbl;
        private System.Windows.Forms.Label ptoimipaikkaLbl;
        private System.Windows.Forms.Label OpuhelinLbl;
        private System.Windows.Forms.Label VpuhelinLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label osastoLbl;
        private System.Windows.Forms.Label titteliLbl;
    }
}

