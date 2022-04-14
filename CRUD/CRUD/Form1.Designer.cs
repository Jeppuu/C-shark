namespace CRUD
{
    partial class yllapitoForm
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
            this.idLbl = new System.Windows.Forms.Label();
            this.enimiLbl = new System.Windows.Forms.Label();
            this.snimiLbl = new System.Windows.Forms.Label();
            this.idTxb = new System.Windows.Forms.TextBox();
            this.enimiTxb = new System.Windows.Forms.TextBox();
            this.snimiTxb = new System.Windows.Forms.TextBox();
            this.opiskelijanroTxb = new System.Windows.Forms.TextBox();
            this.emailTxb = new System.Windows.Forms.TextBox();
            this.puhelinTxb = new System.Windows.Forms.TextBox();
            this.opiskelijanumeroLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.puhelinLbl = new System.Windows.Forms.Label();
            this.tyhjennaBtn = new System.Windows.Forms.Button();
            this.tallennaBtn = new System.Windows.Forms.Button();
            this.paivitaBtn = new System.Windows.Forms.Button();
            this.poistaBtn = new System.Windows.Forms.Button();
            this.tietotauluDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // idLbl
            // 
            this.idLbl.Location = new System.Drawing.Point(20, 26);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(78, 27);
            this.idLbl.TabIndex = 0;
            this.idLbl.Text = "ID:";
            this.idLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // enimiLbl
            // 
            this.enimiLbl.AutoSize = true;
            this.enimiLbl.Location = new System.Drawing.Point(20, 70);
            this.enimiLbl.Name = "enimiLbl";
            this.enimiLbl.Size = new System.Drawing.Size(80, 25);
            this.enimiLbl.TabIndex = 1;
            this.enimiLbl.Text = "Etunimi:";
            // 
            // snimiLbl
            // 
            this.snimiLbl.AutoSize = true;
            this.snimiLbl.Location = new System.Drawing.Point(5, 112);
            this.snimiLbl.Name = "snimiLbl";
            this.snimiLbl.Size = new System.Drawing.Size(94, 25);
            this.snimiLbl.TabIndex = 2;
            this.snimiLbl.Text = "Sukunimi:";
            // 
            // idTxb
            // 
            this.idTxb.Enabled = false;
            this.idTxb.Location = new System.Drawing.Point(104, 23);
            this.idTxb.Name = "idTxb";
            this.idTxb.Size = new System.Drawing.Size(170, 33);
            this.idTxb.TabIndex = 4;
            // 
            // enimiTxb
            // 
            this.enimiTxb.Location = new System.Drawing.Point(104, 65);
            this.enimiTxb.Name = "enimiTxb";
            this.enimiTxb.Size = new System.Drawing.Size(170, 33);
            this.enimiTxb.TabIndex = 5;
            // 
            // snimiTxb
            // 
            this.snimiTxb.Location = new System.Drawing.Point(104, 109);
            this.snimiTxb.Name = "snimiTxb";
            this.snimiTxb.Size = new System.Drawing.Size(170, 33);
            this.snimiTxb.TabIndex = 6;
            // 
            // opiskelijanroTxb
            // 
            this.opiskelijanroTxb.Location = new System.Drawing.Point(450, 107);
            this.opiskelijanroTxb.Name = "opiskelijanroTxb";
            this.opiskelijanroTxb.Size = new System.Drawing.Size(170, 33);
            this.opiskelijanroTxb.TabIndex = 12;
            // 
            // emailTxb
            // 
            this.emailTxb.Location = new System.Drawing.Point(450, 63);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(170, 33);
            this.emailTxb.TabIndex = 11;
            // 
            // puhelinTxb
            // 
            this.puhelinTxb.Location = new System.Drawing.Point(450, 21);
            this.puhelinTxb.Name = "puhelinTxb";
            this.puhelinTxb.Size = new System.Drawing.Size(170, 33);
            this.puhelinTxb.TabIndex = 10;
            // 
            // opiskelijanumeroLbl
            // 
            this.opiskelijanumeroLbl.AutoSize = true;
            this.opiskelijanumeroLbl.Location = new System.Drawing.Point(282, 107);
            this.opiskelijanumeroLbl.Name = "opiskelijanumeroLbl";
            this.opiskelijanumeroLbl.Size = new System.Drawing.Size(164, 25);
            this.opiskelijanumeroLbl.TabIndex = 9;
            this.opiskelijanumeroLbl.Text = "Opiskelijanumero:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(337, 63);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(108, 25);
            this.emailLbl.TabIndex = 8;
            this.emailLbl.Text = "Sähköposti:";
            // 
            // puhelinLbl
            // 
            this.puhelinLbl.AutoSize = true;
            this.puhelinLbl.Location = new System.Drawing.Point(365, 21);
            this.puhelinLbl.Name = "puhelinLbl";
            this.puhelinLbl.Size = new System.Drawing.Size(80, 25);
            this.puhelinLbl.TabIndex = 7;
            this.puhelinLbl.Text = "Puhelin:";
            // 
            // tyhjennaBtn
            // 
            this.tyhjennaBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.tyhjennaBtn.FlatAppearance.BorderSize = 0;
            this.tyhjennaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tyhjennaBtn.ForeColor = System.Drawing.Color.White;
            this.tyhjennaBtn.Location = new System.Drawing.Point(12, 166);
            this.tyhjennaBtn.Name = "tyhjennaBtn";
            this.tyhjennaBtn.Size = new System.Drawing.Size(110, 40);
            this.tyhjennaBtn.TabIndex = 13;
            this.tyhjennaBtn.Text = "Tyhjennä";
            this.tyhjennaBtn.UseVisualStyleBackColor = false;
            this.tyhjennaBtn.Click += new System.EventHandler(this.tyhjennaBtn_Click);
            // 
            // tallennaBtn
            // 
            this.tallennaBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.tallennaBtn.FlatAppearance.BorderSize = 0;
            this.tallennaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tallennaBtn.ForeColor = System.Drawing.Color.White;
            this.tallennaBtn.Location = new System.Drawing.Point(178, 166);
            this.tallennaBtn.Name = "tallennaBtn";
            this.tallennaBtn.Size = new System.Drawing.Size(110, 40);
            this.tallennaBtn.TabIndex = 14;
            this.tallennaBtn.Text = "Tallenna";
            this.tallennaBtn.UseVisualStyleBackColor = false;
            this.tallennaBtn.Click += new System.EventHandler(this.tallennaBtn_Click);
            // 
            // paivitaBtn
            // 
            this.paivitaBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.paivitaBtn.FlatAppearance.BorderSize = 0;
            this.paivitaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paivitaBtn.ForeColor = System.Drawing.Color.White;
            this.paivitaBtn.Location = new System.Drawing.Point(344, 166);
            this.paivitaBtn.Name = "paivitaBtn";
            this.paivitaBtn.Size = new System.Drawing.Size(110, 40);
            this.paivitaBtn.TabIndex = 15;
            this.paivitaBtn.Text = "Päivitä";
            this.paivitaBtn.UseVisualStyleBackColor = false;
            this.paivitaBtn.Click += new System.EventHandler(this.paivitaBtn_Click);
            // 
            // poistaBtn
            // 
            this.poistaBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.poistaBtn.FlatAppearance.BorderSize = 0;
            this.poistaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poistaBtn.ForeColor = System.Drawing.Color.White;
            this.poistaBtn.Location = new System.Drawing.Point(510, 166);
            this.poistaBtn.Name = "poistaBtn";
            this.poistaBtn.Size = new System.Drawing.Size(110, 40);
            this.poistaBtn.TabIndex = 16;
            this.poistaBtn.Text = "Poista";
            this.poistaBtn.UseVisualStyleBackColor = false;
            this.poistaBtn.Click += new System.EventHandler(this.poistaBtn_Click);
            // 
            // tietotauluDgv
            // 
            this.tietotauluDgv.AllowUserToResizeColumns = false;
            this.tietotauluDgv.AllowUserToResizeRows = false;
            this.tietotauluDgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tietotauluDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tietotauluDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tietotauluDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tietotauluDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tietotauluDgv.Location = new System.Drawing.Point(9, 213);
            this.tietotauluDgv.Name = "tietotauluDgv";
            this.tietotauluDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tietotauluDgv.Size = new System.Drawing.Size(628, 329);
            this.tietotauluDgv.TabIndex = 17;
            this.tietotauluDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tietotauluDgv_CellClick);
            // 
            // yllapitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 555);
            this.Controls.Add(this.tietotauluDgv);
            this.Controls.Add(this.poistaBtn);
            this.Controls.Add(this.paivitaBtn);
            this.Controls.Add(this.tallennaBtn);
            this.Controls.Add(this.tyhjennaBtn);
            this.Controls.Add(this.opiskelijanroTxb);
            this.Controls.Add(this.emailTxb);
            this.Controls.Add(this.puhelinTxb);
            this.Controls.Add(this.opiskelijanumeroLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.puhelinLbl);
            this.Controls.Add(this.snimiTxb);
            this.Controls.Add(this.enimiTxb);
            this.Controls.Add(this.idTxb);
            this.Controls.Add(this.snimiLbl);
            this.Controls.Add(this.enimiLbl);
            this.Controls.Add(this.idLbl);
            this.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "yllapitoForm";
            this.Text = "Opiskelijarekisterin ylläpito";
            this.Load += new System.EventHandler(this.yllapitoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label enimiLbl;
        private System.Windows.Forms.Label snimiLbl;
        private System.Windows.Forms.TextBox idTxb;
        private System.Windows.Forms.TextBox enimiTxb;
        private System.Windows.Forms.TextBox snimiTxb;
        private System.Windows.Forms.TextBox opiskelijanroTxb;
        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.TextBox puhelinTxb;
        private System.Windows.Forms.Label opiskelijanumeroLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label puhelinLbl;
        private System.Windows.Forms.Button tyhjennaBtn;
        private System.Windows.Forms.Button tallennaBtn;
        private System.Windows.Forms.Button paivitaBtn;
        private System.Windows.Forms.Button poistaBtn;
        private System.Windows.Forms.DataGridView tietotauluDgv;
    }
}

