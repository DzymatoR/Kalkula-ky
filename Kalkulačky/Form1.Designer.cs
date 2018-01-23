namespace Kalkulačky
{
    partial class Kalkulacky
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalkulacky));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vzdalenostLBL = new System.Windows.Forms.Label();
            this.spotrebaLBL = new System.Windows.Forms.Label();
            this.cenaLBL = new System.Windows.Forms.Label();
            this.benzinVysledekLBL = new System.Windows.Forms.Label();
            this.vzdalenostNUD = new System.Windows.Forms.NumericUpDown();
            this.spotrebaNUD = new System.Windows.Forms.NumericUpDown();
            this.cenaNUD = new System.Windows.Forms.NumericUpDown();
            this.benzinBTN = new System.Windows.Forms.Button();
            this.prikonLBL = new System.Windows.Forms.Label();
            this.provozLBL = new System.Windows.Forms.Label();
            this.cenaKwhLBL = new System.Windows.Forms.Label();
            this.energieVysledekHnedLBL = new System.Windows.Forms.Label();
            this.prikonNUD = new System.Windows.Forms.NumericUpDown();
            this.dobaNUD = new System.Windows.Forms.NumericUpDown();
            this.cenaKwhNUD = new System.Windows.Forms.NumericUpDown();
            this.energieBTN = new System.Windows.Forms.Button();
            this.energieVysledekMesicLBL = new System.Windows.Forms.Label();
            this.energieVysledekRokLBL = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vzdalenostNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotrebaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikonNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaKwhNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.Controls.Add(this.benzinBTN);
            this.tabPage1.Controls.Add(this.cenaNUD);
            this.tabPage1.Controls.Add(this.spotrebaNUD);
            this.tabPage1.Controls.Add(this.vzdalenostNUD);
            this.tabPage1.Controls.Add(this.benzinVysledekLBL);
            this.tabPage1.Controls.Add(this.cenaLBL);
            this.tabPage1.Controls.Add(this.spotrebaLBL);
            this.tabPage1.Controls.Add(this.vzdalenostLBL);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Benzín";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Controls.Add(this.energieVysledekRokLBL);
            this.tabPage2.Controls.Add(this.energieVysledekMesicLBL);
            this.tabPage2.Controls.Add(this.energieBTN);
            this.tabPage2.Controls.Add(this.cenaKwhNUD);
            this.tabPage2.Controls.Add(this.dobaNUD);
            this.tabPage2.Controls.Add(this.prikonNUD);
            this.tabPage2.Controls.Add(this.energieVysledekHnedLBL);
            this.tabPage2.Controls.Add(this.cenaKwhLBL);
            this.tabPage2.Controls.Add(this.provozLBL);
            this.tabPage2.Controls.Add(this.prikonLBL);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Energie";
            // 
            // vzdalenostLBL
            // 
            this.vzdalenostLBL.AutoSize = true;
            this.vzdalenostLBL.Location = new System.Drawing.Point(30, 23);
            this.vzdalenostLBL.Name = "vzdalenostLBL";
            this.vzdalenostLBL.Size = new System.Drawing.Size(82, 13);
            this.vzdalenostLBL.TabIndex = 0;
            this.vzdalenostLBL.Text = "Vzdálenost (km)";
            // 
            // spotrebaLBL
            // 
            this.spotrebaLBL.AutoSize = true;
            this.spotrebaLBL.Location = new System.Drawing.Point(30, 74);
            this.spotrebaLBL.Name = "spotrebaLBL";
            this.spotrebaLBL.Size = new System.Drawing.Size(108, 13);
            this.spotrebaLBL.TabIndex = 1;
            this.spotrebaLBL.Text = "Spotřeba (l / 100 km)";
            // 
            // cenaLBL
            // 
            this.cenaLBL.AutoSize = true;
            this.cenaLBL.Location = new System.Drawing.Point(30, 124);
            this.cenaLBL.Name = "cenaLBL";
            this.cenaLBL.Size = new System.Drawing.Size(67, 13);
            this.cenaLBL.TabIndex = 2;
            this.cenaLBL.Text = "Cena (Kč / l)";
            // 
            // benzinVysledekLBL
            // 
            this.benzinVysledekLBL.AutoSize = true;
            this.benzinVysledekLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.benzinVysledekLBL.Location = new System.Drawing.Point(30, 270);
            this.benzinVysledekLBL.Name = "benzinVysledekLBL";
            this.benzinVysledekLBL.Size = new System.Drawing.Size(100, 25);
            this.benzinVysledekLBL.TabIndex = 3;
            this.benzinVysledekLBL.Text = "Výsledek";
            // 
            // vzdalenostNUD
            // 
            this.vzdalenostNUD.DecimalPlaces = 1;
            this.vzdalenostNUD.Location = new System.Drawing.Point(33, 40);
            this.vzdalenostNUD.Name = "vzdalenostNUD";
            this.vzdalenostNUD.Size = new System.Drawing.Size(120, 20);
            this.vzdalenostNUD.TabIndex = 4;
            // 
            // spotrebaNUD
            // 
            this.spotrebaNUD.DecimalPlaces = 1;
            this.spotrebaNUD.Location = new System.Drawing.Point(33, 90);
            this.spotrebaNUD.Name = "spotrebaNUD";
            this.spotrebaNUD.Size = new System.Drawing.Size(120, 20);
            this.spotrebaNUD.TabIndex = 5;
            this.spotrebaNUD.Value = new decimal(new int[] {
            65,
            0,
            0,
            65536});
            // 
            // cenaNUD
            // 
            this.cenaNUD.DecimalPlaces = 1;
            this.cenaNUD.Location = new System.Drawing.Point(33, 140);
            this.cenaNUD.Name = "cenaNUD";
            this.cenaNUD.Size = new System.Drawing.Size(120, 20);
            this.cenaNUD.TabIndex = 6;
            this.cenaNUD.Value = new decimal(new int[] {
            27,
            0,
            0,
            0});
            // 
            // benzinBTN
            // 
            this.benzinBTN.BackColor = System.Drawing.Color.OrangeRed;
            this.benzinBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.benzinBTN.Location = new System.Drawing.Point(33, 209);
            this.benzinBTN.Name = "benzinBTN";
            this.benzinBTN.Size = new System.Drawing.Size(120, 40);
            this.benzinBTN.TabIndex = 7;
            this.benzinBTN.Text = "Spočítej";
            this.benzinBTN.UseVisualStyleBackColor = false;
            this.benzinBTN.Click += new System.EventHandler(this.benzinBTN_Click);
            // 
            // prikonLBL
            // 
            this.prikonLBL.AutoSize = true;
            this.prikonLBL.Location = new System.Drawing.Point(30, 23);
            this.prikonLBL.Name = "prikonLBL";
            this.prikonLBL.Size = new System.Drawing.Size(72, 13);
            this.prikonLBL.TabIndex = 0;
            this.prikonLBL.Text = "Příkon (kWh)";
            // 
            // provozLBL
            // 
            this.provozLBL.AutoSize = true;
            this.provozLBL.Location = new System.Drawing.Point(30, 74);
            this.provozLBL.Name = "provozLBL";
            this.provozLBL.Size = new System.Drawing.Size(122, 13);
            this.provozLBL.TabIndex = 1;
            this.provozLBL.Text = "Doba provozu denně (h)";
            // 
            // cenaKwhLBL
            // 
            this.cenaKwhLBL.AutoSize = true;
            this.cenaKwhLBL.Location = new System.Drawing.Point(30, 124);
            this.cenaKwhLBL.Name = "cenaKwhLBL";
            this.cenaKwhLBL.Size = new System.Drawing.Size(78, 13);
            this.cenaKwhLBL.TabIndex = 2;
            this.cenaKwhLBL.Text = "Cena (za kWh)";
            // 
            // energieVysledekHnedLBL
            // 
            this.energieVysledekHnedLBL.AutoSize = true;
            this.energieVysledekHnedLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.energieVysledekHnedLBL.Location = new System.Drawing.Point(30, 270);
            this.energieVysledekHnedLBL.Name = "energieVysledekHnedLBL";
            this.energieVysledekHnedLBL.Size = new System.Drawing.Size(100, 25);
            this.energieVysledekHnedLBL.TabIndex = 3;
            this.energieVysledekHnedLBL.Text = "Výsledek";
            // 
            // prikonNUD
            // 
            this.prikonNUD.DecimalPlaces = 1;
            this.prikonNUD.Location = new System.Drawing.Point(33, 40);
            this.prikonNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prikonNUD.Name = "prikonNUD";
            this.prikonNUD.Size = new System.Drawing.Size(120, 20);
            this.prikonNUD.TabIndex = 4;
            this.prikonNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // dobaNUD
            // 
            this.dobaNUD.DecimalPlaces = 1;
            this.dobaNUD.Location = new System.Drawing.Point(33, 90);
            this.dobaNUD.Name = "dobaNUD";
            this.dobaNUD.Size = new System.Drawing.Size(120, 20);
            this.dobaNUD.TabIndex = 5;
            this.dobaNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cenaKwhNUD
            // 
            this.cenaKwhNUD.DecimalPlaces = 2;
            this.cenaKwhNUD.Location = new System.Drawing.Point(33, 140);
            this.cenaKwhNUD.Name = "cenaKwhNUD";
            this.cenaKwhNUD.Size = new System.Drawing.Size(120, 20);
            this.cenaKwhNUD.TabIndex = 6;
            this.cenaKwhNUD.Value = new decimal(new int[] {
            464,
            0,
            0,
            131072});
            // 
            // energieBTN
            // 
            this.energieBTN.BackColor = System.Drawing.Color.OrangeRed;
            this.energieBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.energieBTN.Location = new System.Drawing.Point(33, 209);
            this.energieBTN.Name = "energieBTN";
            this.energieBTN.Size = new System.Drawing.Size(120, 40);
            this.energieBTN.TabIndex = 7;
            this.energieBTN.Text = "Spočítej";
            this.energieBTN.UseVisualStyleBackColor = false;
            this.energieBTN.Click += new System.EventHandler(this.energieBTN_Click);
            // 
            // energieVysledekMesicLBL
            // 
            this.energieVysledekMesicLBL.AutoSize = true;
            this.energieVysledekMesicLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.energieVysledekMesicLBL.Location = new System.Drawing.Point(30, 305);
            this.energieVysledekMesicLBL.Name = "energieVysledekMesicLBL";
            this.energieVysledekMesicLBL.Size = new System.Drawing.Size(100, 25);
            this.energieVysledekMesicLBL.TabIndex = 8;
            this.energieVysledekMesicLBL.Text = "Výsledek";
            // 
            // energieVysledekRokLBL
            // 
            this.energieVysledekRokLBL.AutoSize = true;
            this.energieVysledekRokLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.energieVysledekRokLBL.Location = new System.Drawing.Point(30, 340);
            this.energieVysledekRokLBL.Name = "energieVysledekRokLBL";
            this.energieVysledekRokLBL.Size = new System.Drawing.Size(100, 25);
            this.energieVysledekRokLBL.TabIndex = 9;
            this.energieVysledekRokLBL.Text = "Výsledek";
            // 
            // Kalkulacky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kalkulacky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulačky";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vzdalenostNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotrebaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikonNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaKwhNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button benzinBTN;
        private System.Windows.Forms.NumericUpDown cenaNUD;
        private System.Windows.Forms.NumericUpDown spotrebaNUD;
        private System.Windows.Forms.NumericUpDown vzdalenostNUD;
        private System.Windows.Forms.Label benzinVysledekLBL;
        private System.Windows.Forms.Label cenaLBL;
        private System.Windows.Forms.Label spotrebaLBL;
        private System.Windows.Forms.Label vzdalenostLBL;
        private System.Windows.Forms.Button energieBTN;
        private System.Windows.Forms.NumericUpDown cenaKwhNUD;
        private System.Windows.Forms.NumericUpDown dobaNUD;
        private System.Windows.Forms.NumericUpDown prikonNUD;
        private System.Windows.Forms.Label energieVysledekHnedLBL;
        private System.Windows.Forms.Label cenaKwhLBL;
        private System.Windows.Forms.Label provozLBL;
        private System.Windows.Forms.Label prikonLBL;
        private System.Windows.Forms.Label energieVysledekRokLBL;
        private System.Windows.Forms.Label energieVysledekMesicLBL;
    }
}

