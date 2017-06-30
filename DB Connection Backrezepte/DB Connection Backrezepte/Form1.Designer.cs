namespace DB_Connection_Backrezepte
{
    partial class mainform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_rezepte = new System.Windows.Forms.TabPage();
            this.btn_zutatausrezeptentf = new System.Windows.Forms.Button();
            this.btn_zutatenzurezepthinzu = new System.Windows.Forms.Button();
            this.btn_zutatenfurrezept = new System.Windows.Forms.Button();
            this.btn_rezeptentf = new System.Windows.Forms.Button();
            this.btn_rezepthinzu = new System.Windows.Forms.Button();
            this.tabPagebk = new System.Windows.Forms.TabPage();
            this.btn_b_mengebrechnen = new System.Windows.Forms.Button();
            this.btn_b_showzutaten = new System.Windows.Forms.Button();
            this.btn_b_rezepteanz = new System.Windows.Forms.Button();
            this.tabPage_lager = new System.Windows.Forms.TabPage();
            this.btn_lieferung = new System.Windows.Forms.Button();
            this.btn_zutathinzu = new System.Windows.Forms.Button();
            this.tabPage_lieferanten = new System.Windows.Forms.TabPage();
            this.btn_rezepte = new System.Windows.Forms.Button();
            this.btn_lager = new System.Windows.Forms.Button();
            this.btn_lieferanten = new System.Windows.Forms.Button();
            this.btn_test_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_bestellen = new System.Windows.Forms.Button();
            this.btn_lieferanthinzu = new System.Windows.Forms.Button();
            this.btn_lieferantenentf = new System.Windows.Forms.Button();
            this.btn_werliefertwas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_rezepte.SuspendLayout();
            this.tabPagebk.SuspendLayout();
            this.tabPage_lager.SuspendLayout();
            this.tabPage_lieferanten.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(646, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(676, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(506, 412);
            this.dataGridView2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_rezepte);
            this.tabControl1.Controls.Add(this.tabPagebk);
            this.tabControl1.Controls.Add(this.tabPage_lager);
            this.tabControl1.Controls.Add(this.tabPage_lieferanten);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 512);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1194, 80);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage_rezepte
            // 
            this.tabPage_rezepte.Controls.Add(this.btn_zutatausrezeptentf);
            this.tabPage_rezepte.Controls.Add(this.btn_zutatenzurezepthinzu);
            this.tabPage_rezepte.Controls.Add(this.btn_zutatenfurrezept);
            this.tabPage_rezepte.Controls.Add(this.btn_rezeptentf);
            this.tabPage_rezepte.Controls.Add(this.btn_rezepthinzu);
            this.tabPage_rezepte.Location = new System.Drawing.Point(4, 22);
            this.tabPage_rezepte.Name = "tabPage_rezepte";
            this.tabPage_rezepte.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_rezepte.Size = new System.Drawing.Size(1186, 54);
            this.tabPage_rezepte.TabIndex = 0;
            this.tabPage_rezepte.Text = "Rezepte";
            this.tabPage_rezepte.UseVisualStyleBackColor = true;
            // 
            // btn_zutatausrezeptentf
            // 
            this.btn_zutatausrezeptentf.Location = new System.Drawing.Point(556, 5);
            this.btn_zutatausrezeptentf.Name = "btn_zutatausrezeptentf";
            this.btn_zutatausrezeptentf.Size = new System.Drawing.Size(162, 23);
            this.btn_zutatausrezeptentf.TabIndex = 4;
            this.btn_zutatausrezeptentf.Text = "Zutaten aus Rezept entfernen";
            this.btn_zutatausrezeptentf.UseVisualStyleBackColor = true;
            this.btn_zutatausrezeptentf.Click += new System.EventHandler(this.btn_zutatausrezeptentf_Click);
            // 
            // btn_zutatenzurezepthinzu
            // 
            this.btn_zutatenzurezepthinzu.Location = new System.Drawing.Point(395, 6);
            this.btn_zutatenzurezepthinzu.Name = "btn_zutatenzurezepthinzu";
            this.btn_zutatenzurezepthinzu.Size = new System.Drawing.Size(154, 23);
            this.btn_zutatenzurezepthinzu.TabIndex = 3;
            this.btn_zutatenzurezepthinzu.Text = "Zutat zu Rezept hinzufügen";
            this.btn_zutatenzurezepthinzu.UseVisualStyleBackColor = true;
            this.btn_zutatenzurezepthinzu.Click += new System.EventHandler(this.btn_zutatenzurezepthinzu_Click);
            // 
            // btn_zutatenfurrezept
            // 
            this.btn_zutatenfurrezept.Location = new System.Drawing.Point(222, 6);
            this.btn_zutatenfurrezept.Name = "btn_zutatenfurrezept";
            this.btn_zutatenfurrezept.Size = new System.Drawing.Size(167, 23);
            this.btn_zutatenfurrezept.TabIndex = 2;
            this.btn_zutatenfurrezept.Text = "Zutaten des Rezeptes anzeigen";
            this.btn_zutatenfurrezept.UseVisualStyleBackColor = true;
            this.btn_zutatenfurrezept.Click += new System.EventHandler(this.btn_zutatenfurrezept_Click);
            // 
            // btn_rezeptentf
            // 
            this.btn_rezeptentf.Location = new System.Drawing.Point(117, 6);
            this.btn_rezeptentf.Name = "btn_rezeptentf";
            this.btn_rezeptentf.Size = new System.Drawing.Size(99, 23);
            this.btn_rezeptentf.TabIndex = 1;
            this.btn_rezeptentf.Text = "Rezept entfernen";
            this.btn_rezeptentf.UseVisualStyleBackColor = true;
            this.btn_rezeptentf.Click += new System.EventHandler(this.btn_rezeptentf_Click);
            // 
            // btn_rezepthinzu
            // 
            this.btn_rezepthinzu.Location = new System.Drawing.Point(6, 6);
            this.btn_rezepthinzu.Name = "btn_rezepthinzu";
            this.btn_rezepthinzu.Size = new System.Drawing.Size(105, 23);
            this.btn_rezepthinzu.TabIndex = 0;
            this.btn_rezepthinzu.Text = "Rezept hinzufügen";
            this.btn_rezepthinzu.UseVisualStyleBackColor = true;
            this.btn_rezepthinzu.Click += new System.EventHandler(this.btn_rezepthinzu_Click);
            // 
            // tabPagebk
            // 
            this.tabPagebk.Controls.Add(this.btn_b_mengebrechnen);
            this.tabPagebk.Controls.Add(this.btn_b_showzutaten);
            this.tabPagebk.Controls.Add(this.btn_b_rezepteanz);
            this.tabPagebk.Location = new System.Drawing.Point(4, 22);
            this.tabPagebk.Name = "tabPagebk";
            this.tabPagebk.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagebk.Size = new System.Drawing.Size(1186, 54);
            this.tabPagebk.TabIndex = 1;
            this.tabPagebk.Text = "Bäcker";
            this.tabPagebk.UseVisualStyleBackColor = true;
            // 
            // btn_b_mengebrechnen
            // 
            this.btn_b_mengebrechnen.Location = new System.Drawing.Point(248, 6);
            this.btn_b_mengebrechnen.Name = "btn_b_mengebrechnen";
            this.btn_b_mengebrechnen.Size = new System.Drawing.Size(148, 23);
            this.btn_b_mengebrechnen.TabIndex = 2;
            this.btn_b_mengebrechnen.Text = "Menge für x Stk. berechnen";
            this.btn_b_mengebrechnen.UseVisualStyleBackColor = true;
            this.btn_b_mengebrechnen.Click += new System.EventHandler(this.btn_b_mengebrechnen_Click);
            // 
            // btn_b_showzutaten
            // 
            this.btn_b_showzutaten.Location = new System.Drawing.Point(117, 6);
            this.btn_b_showzutaten.Name = "btn_b_showzutaten";
            this.btn_b_showzutaten.Size = new System.Drawing.Size(125, 23);
            this.btn_b_showzutaten.TabIndex = 1;
            this.btn_b_showzutaten.Text = "Zutaten des Rezeptes anzeigen";
            this.btn_b_showzutaten.UseVisualStyleBackColor = true;
            this.btn_b_showzutaten.Click += new System.EventHandler(this.btn_b_showzutaten_Click);
            // 
            // btn_b_rezepteanz
            // 
            this.btn_b_rezepteanz.Location = new System.Drawing.Point(6, 6);
            this.btn_b_rezepteanz.Name = "btn_b_rezepteanz";
            this.btn_b_rezepteanz.Size = new System.Drawing.Size(105, 23);
            this.btn_b_rezepteanz.TabIndex = 0;
            this.btn_b_rezepteanz.Text = "Rezepte anzeigen";
            this.btn_b_rezepteanz.UseVisualStyleBackColor = true;
            this.btn_b_rezepteanz.Click += new System.EventHandler(this.btn_b_rezepteanz_Click);
            // 
            // tabPage_lager
            // 
            this.tabPage_lager.Controls.Add(this.btn_bestellen);
            this.tabPage_lager.Controls.Add(this.btn_lieferung);
            this.tabPage_lager.Controls.Add(this.btn_zutathinzu);
            this.tabPage_lager.Location = new System.Drawing.Point(4, 22);
            this.tabPage_lager.Name = "tabPage_lager";
            this.tabPage_lager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_lager.Size = new System.Drawing.Size(1186, 54);
            this.tabPage_lager.TabIndex = 2;
            this.tabPage_lager.Text = "Lager";
            this.tabPage_lager.UseVisualStyleBackColor = true;
            // 
            // btn_lieferung
            // 
            this.btn_lieferung.Location = new System.Drawing.Point(123, 6);
            this.btn_lieferung.Name = "btn_lieferung";
            this.btn_lieferung.Size = new System.Drawing.Size(221, 23);
            this.btn_lieferung.TabIndex = 1;
            this.btn_lieferung.Text = "Lieferung für ausgewählte Zutat hinzufügen";
            this.btn_lieferung.UseVisualStyleBackColor = true;
            this.btn_lieferung.Click += new System.EventHandler(this.btn_lieferung_Click);
            // 
            // btn_zutathinzu
            // 
            this.btn_zutathinzu.Location = new System.Drawing.Point(6, 6);
            this.btn_zutathinzu.Name = "btn_zutathinzu";
            this.btn_zutathinzu.Size = new System.Drawing.Size(111, 23);
            this.btn_zutathinzu.TabIndex = 0;
            this.btn_zutathinzu.Text = "Zutat hinzufügen";
            this.btn_zutathinzu.UseVisualStyleBackColor = true;
            this.btn_zutathinzu.Click += new System.EventHandler(this.btn_zutathinzu_Click);
            // 
            // tabPage_lieferanten
            // 
            this.tabPage_lieferanten.Controls.Add(this.btn_werliefertwas);
            this.tabPage_lieferanten.Controls.Add(this.btn_lieferantenentf);
            this.tabPage_lieferanten.Controls.Add(this.btn_lieferanthinzu);
            this.tabPage_lieferanten.Location = new System.Drawing.Point(4, 22);
            this.tabPage_lieferanten.Name = "tabPage_lieferanten";
            this.tabPage_lieferanten.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_lieferanten.Size = new System.Drawing.Size(1186, 54);
            this.tabPage_lieferanten.TabIndex = 3;
            this.tabPage_lieferanten.Text = "Lieferanten";
            this.tabPage_lieferanten.UseVisualStyleBackColor = true;
            // 
            // btn_rezepte
            // 
            this.btn_rezepte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_rezepte.Location = new System.Drawing.Point(15, 483);
            this.btn_rezepte.Name = "btn_rezepte";
            this.btn_rezepte.Size = new System.Drawing.Size(75, 23);
            this.btn_rezepte.TabIndex = 4;
            this.btn_rezepte.Text = "Rezepte (↺)";
            this.btn_rezepte.UseVisualStyleBackColor = true;
            this.btn_rezepte.Click += new System.EventHandler(this.btn_rezepte_Click);
            // 
            // btn_lager
            // 
            this.btn_lager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_lager.Location = new System.Drawing.Point(93, 483);
            this.btn_lager.Name = "btn_lager";
            this.btn_lager.Size = new System.Drawing.Size(75, 23);
            this.btn_lager.TabIndex = 5;
            this.btn_lager.Text = "Lager (↺) ";
            this.btn_lager.UseVisualStyleBackColor = true;
            this.btn_lager.Click += new System.EventHandler(this.btn_lager_Click);
            // 
            // btn_lieferanten
            // 
            this.btn_lieferanten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_lieferanten.Location = new System.Drawing.Point(174, 483);
            this.btn_lieferanten.Name = "btn_lieferanten";
            this.btn_lieferanten.Size = new System.Drawing.Size(86, 23);
            this.btn_lieferanten.TabIndex = 6;
            this.btn_lieferanten.Text = "Lieferanten (↺)";
            this.btn_lieferanten.UseVisualStyleBackColor = true;
            this.btn_lieferanten.Click += new System.EventHandler(this.btn_lieferanten_Click);
            // 
            // btn_test_1
            // 
            this.btn_test_1.Location = new System.Drawing.Point(968, 23);
            this.btn_test_1.Name = "btn_test_1";
            this.btn_test_1.Size = new System.Drawing.Size(75, 23);
            this.btn_test_1.TabIndex = 7;
            this.btn_test_1.Text = "Testbutton1";
            this.btn_test_1.UseVisualStyleBackColor = true;
            this.btn_test_1.Click += new System.EventHandler(this.btn_test_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Suche:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Auswahl:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Info:";
            // 
            // btn_bestellen
            // 
            this.btn_bestellen.Location = new System.Drawing.Point(350, 6);
            this.btn_bestellen.Name = "btn_bestellen";
            this.btn_bestellen.Size = new System.Drawing.Size(183, 23);
            this.btn_bestellen.TabIndex = 2;
            this.btn_bestellen.Text = "Zu bestellende Produkte anzeigen";
            this.btn_bestellen.UseVisualStyleBackColor = true;
            this.btn_bestellen.Click += new System.EventHandler(this.btn_bestellen_Click);
            // 
            // btn_lieferanthinzu
            // 
            this.btn_lieferanthinzu.Location = new System.Drawing.Point(6, 6);
            this.btn_lieferanthinzu.Name = "btn_lieferanthinzu";
            this.btn_lieferanthinzu.Size = new System.Drawing.Size(136, 23);
            this.btn_lieferanthinzu.TabIndex = 0;
            this.btn_lieferanthinzu.Text = "Lieferant hinzufügen";
            this.btn_lieferanthinzu.UseVisualStyleBackColor = true;
            this.btn_lieferanthinzu.Click += new System.EventHandler(this.btn_lieferanthinzu_Click);
            // 
            // btn_lieferantenentf
            // 
            this.btn_lieferantenentf.Location = new System.Drawing.Point(148, 6);
            this.btn_lieferantenentf.Name = "btn_lieferantenentf";
            this.btn_lieferantenentf.Size = new System.Drawing.Size(108, 23);
            this.btn_lieferantenentf.TabIndex = 1;
            this.btn_lieferantenentf.Text = "Lieferant entfernen";
            this.btn_lieferantenentf.UseVisualStyleBackColor = true;
            this.btn_lieferantenentf.Click += new System.EventHandler(this.btn_lieferantenentf_Click);
            // 
            // btn_werliefertwas
            // 
            this.btn_werliefertwas.Location = new System.Drawing.Point(262, 6);
            this.btn_werliefertwas.Name = "btn_werliefertwas";
            this.btn_werliefertwas.Size = new System.Drawing.Size(178, 23);
            this.btn_werliefertwas.TabIndex = 2;
            this.btn_werliefertwas.Text = "wer liefert eine bestimmte Zutat";
            this.btn_werliefertwas.UseVisualStyleBackColor = true;
            this.btn_werliefertwas.Click += new System.EventHandler(this.btn_werliefertwas_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_test_1);
            this.Controls.Add(this.btn_lieferanten);
            this.Controls.Add(this.btn_lager);
            this.Controls.Add(this.btn_rezepte);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_rezepte.ResumeLayout(false);
            this.tabPagebk.ResumeLayout(false);
            this.tabPage_lager.ResumeLayout(false);
            this.tabPage_lieferanten.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_rezepte;
        private System.Windows.Forms.TabPage tabPagebk;
        private System.Windows.Forms.Button btn_rezepte;
        private System.Windows.Forms.Button btn_lager;
        private System.Windows.Forms.Button btn_lieferanten;
        private System.Windows.Forms.Button btn_test_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_rezepthinzu;
        private System.Windows.Forms.TabPage tabPage_lager;
        private System.Windows.Forms.TabPage tabPage_lieferanten;
        private System.Windows.Forms.Button btn_rezeptentf;
        private System.Windows.Forms.Button btn_zutatenfurrezept;
        private System.Windows.Forms.Button btn_b_rezepteanz;
        private System.Windows.Forms.Button btn_b_showzutaten;
        private System.Windows.Forms.Button btn_b_mengebrechnen;
        private System.Windows.Forms.Button btn_zutatenzurezepthinzu;
        private System.Windows.Forms.Button btn_zutatausrezeptentf;
        private System.Windows.Forms.Button btn_zutathinzu;
        private System.Windows.Forms.Button btn_lieferung;
        private System.Windows.Forms.Button btn_bestellen;
        private System.Windows.Forms.Button btn_lieferanthinzu;
        private System.Windows.Forms.Button btn_lieferantenentf;
        private System.Windows.Forms.Button btn_werliefertwas;
    }
}

