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
            this.tabPagevw = new System.Windows.Forms.TabPage();
            this.tabPagebk = new System.Windows.Forms.TabPage();
            this.btn_rezepte = new System.Windows.Forms.Button();
            this.btn_lager = new System.Windows.Forms.Button();
            this.btn_lieferanten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(357, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagevw);
            this.tabControl1.Controls.Add(this.tabPagebk);
            this.tabControl1.Location = new System.Drawing.Point(12, 248);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(682, 210);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPagevw
            // 
            this.tabPagevw.Location = new System.Drawing.Point(4, 22);
            this.tabPagevw.Name = "tabPagevw";
            this.tabPagevw.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagevw.Size = new System.Drawing.Size(674, 184);
            this.tabPagevw.TabIndex = 0;
            this.tabPagevw.Text = "Verwaltung";
            this.tabPagevw.UseVisualStyleBackColor = true;
            // 
            // tabPagebk
            // 
            this.tabPagebk.Location = new System.Drawing.Point(4, 22);
            this.tabPagebk.Name = "tabPagebk";
            this.tabPagebk.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagebk.Size = new System.Drawing.Size(674, 184);
            this.tabPagebk.TabIndex = 1;
            this.tabPagebk.Text = "Bäcker";
            this.tabPagebk.UseVisualStyleBackColor = true;
            // 
            // btn_rezepte
            // 
            this.btn_rezepte.Location = new System.Drawing.Point(12, 194);
            this.btn_rezepte.Name = "btn_rezepte";
            this.btn_rezepte.Size = new System.Drawing.Size(75, 23);
            this.btn_rezepte.TabIndex = 4;
            this.btn_rezepte.Text = "Rezepte";
            this.btn_rezepte.UseVisualStyleBackColor = true;
            this.btn_rezepte.Click += new System.EventHandler(this.btn_rezepte_Click);
            // 
            // btn_lager
            // 
            this.btn_lager.Location = new System.Drawing.Point(93, 194);
            this.btn_lager.Name = "btn_lager";
            this.btn_lager.Size = new System.Drawing.Size(75, 23);
            this.btn_lager.TabIndex = 5;
            this.btn_lager.Text = "Lager";
            this.btn_lager.UseVisualStyleBackColor = true;
            this.btn_lager.Click += new System.EventHandler(this.btn_lager_Click);
            // 
            // btn_lieferanten
            // 
            this.btn_lieferanten.Location = new System.Drawing.Point(174, 194);
            this.btn_lieferanten.Name = "btn_lieferanten";
            this.btn_lieferanten.Size = new System.Drawing.Size(75, 23);
            this.btn_lieferanten.TabIndex = 6;
            this.btn_lieferanten.Text = "Lieferanten";
            this.btn_lieferanten.UseVisualStyleBackColor = true;
            this.btn_lieferanten.Click += new System.EventHandler(this.btn_lieferanten_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 517);
            this.Controls.Add(this.btn_lieferanten);
            this.Controls.Add(this.btn_lager);
            this.Controls.Add(this.btn_rezepte);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mainform";
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagevw;
        private System.Windows.Forms.TabPage tabPagebk;
        private System.Windows.Forms.Button btn_rezepte;
        private System.Windows.Forms.Button btn_lager;
        private System.Windows.Forms.Button btn_lieferanten;
    }
}

