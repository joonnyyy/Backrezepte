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
            this.tabPagebk = new System.Windows.Forms.TabPage();
            this.btn_rezepte = new System.Windows.Forms.Button();
            this.btn_lager = new System.Windows.Forms.Button();
            this.btn_lieferanten = new System.Windows.Forms.Button();
            this.btn_test_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_rezepthinzu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_rezepte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(562, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(254, 326);
            this.dataGridView2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(544, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_rezepte);
            this.tabControl1.Controls.Add(this.tabPagebk);
            this.tabControl1.Location = new System.Drawing.Point(12, 425);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 80);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage_rezepte
            // 
            this.tabPage_rezepte.Controls.Add(this.btn_rezepthinzu);
            this.tabPage_rezepte.Location = new System.Drawing.Point(4, 22);
            this.tabPage_rezepte.Name = "tabPage_rezepte";
            this.tabPage_rezepte.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_rezepte.Size = new System.Drawing.Size(800, 54);
            this.tabPage_rezepte.TabIndex = 0;
            this.tabPage_rezepte.Text = "Rezepte";
            this.tabPage_rezepte.UseVisualStyleBackColor = true;
            // 
            // tabPagebk
            // 
            this.tabPagebk.Location = new System.Drawing.Point(4, 22);
            this.tabPagebk.Name = "tabPagebk";
            this.tabPagebk.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagebk.Size = new System.Drawing.Size(800, 54);
            this.tabPagebk.TabIndex = 1;
            this.tabPagebk.Text = "Bäcker";
            this.tabPagebk.UseVisualStyleBackColor = true;
            // 
            // btn_rezepte
            // 
            this.btn_rezepte.Location = new System.Drawing.Point(12, 396);
            this.btn_rezepte.Name = "btn_rezepte";
            this.btn_rezepte.Size = new System.Drawing.Size(75, 23);
            this.btn_rezepte.TabIndex = 4;
            this.btn_rezepte.Text = "Rezepte";
            this.btn_rezepte.UseVisualStyleBackColor = true;
            this.btn_rezepte.Click += new System.EventHandler(this.btn_rezepte_Click);
            // 
            // btn_lager
            // 
            this.btn_lager.Location = new System.Drawing.Point(93, 396);
            this.btn_lager.Name = "btn_lager";
            this.btn_lager.Size = new System.Drawing.Size(75, 23);
            this.btn_lager.TabIndex = 5;
            this.btn_lager.Text = "Lager";
            this.btn_lager.UseVisualStyleBackColor = true;
            this.btn_lager.Click += new System.EventHandler(this.btn_lager_Click);
            // 
            // btn_lieferanten
            // 
            this.btn_lieferanten.Location = new System.Drawing.Point(174, 396);
            this.btn_lieferanten.Name = "btn_lieferanten";
            this.btn_lieferanten.Size = new System.Drawing.Size(75, 23);
            this.btn_lieferanten.TabIndex = 6;
            this.btn_lieferanten.Text = "Lieferanten";
            this.btn_lieferanten.UseVisualStyleBackColor = true;
            this.btn_lieferanten.Click += new System.EventHandler(this.btn_lieferanten_Click);
            // 
            // btn_test_1
            // 
            this.btn_test_1.Location = new System.Drawing.Point(347, 396);
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
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Info:";
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
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 517);
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
    }
}

