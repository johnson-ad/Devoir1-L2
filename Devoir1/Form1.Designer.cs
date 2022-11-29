namespace Devoir1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQteStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtRQteStockMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRQteStockMin = new System.Windows.Forms.TextBox();
            this.txtRDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRLibelle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libelle Pr&oduit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProduit
            // 
            this.txtProduit.Location = new System.Drawing.Point(28, 118);
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(251, 20);
            this.txtProduit.TabIndex = 2;
            this.txtProduit.Text = " ";
            this.txtProduit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txtQteStock
            // 
            this.txtQteStock.Location = new System.Drawing.Point(28, 304);
            this.txtQteStock.Name = "txtQteStock";
            this.txtQteStock.Size = new System.Drawing.Size(251, 20);
            this.txtQteStock.TabIndex = 6;
            this.txtQteStock.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantitee en Stock";
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(28, 416);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(251, 20);
            this.txtPU.TabIndex = 8;
            this.txtPU.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prix unitaire";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(28, 590);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(113, 39);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(166, 516);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(113, 39);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "&Modiffier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(28, 516);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(113, 39);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(312, 516);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(113, 39);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(281, 12);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(113, 39);
            this.btnSelectionner.TabIndex = 17;
            this.btnSelectionner.Text = "S&electionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(443, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 492);
            this.dataGridView1.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Controls.Add(this.txtRQteStockMax);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtRQteStockMin);
            this.panel1.Controls.Add(this.txtRDescription);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtRLibelle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(443, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 147);
            this.panel1.TabIndex = 19;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRechercher.Location = new System.Drawing.Point(580, 83);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(155, 36);
            this.btnRechercher.TabIndex = 22;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtRQteStockMax
            // 
            this.txtRQteStockMax.Location = new System.Drawing.Point(575, 48);
            this.txtRQteStockMax.Name = "txtRQteStockMax";
            this.txtRQteStockMax.Size = new System.Drawing.Size(160, 20);
            this.txtRQteStockMax.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(574, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Quantitee en Stock &Max";
            // 
            // txtRQteStockMin
            // 
            this.txtRQteStockMin.Location = new System.Drawing.Point(384, 48);
            this.txtRQteStockMin.Name = "txtRQteStockMin";
            this.txtRQteStockMin.Size = new System.Drawing.Size(160, 20);
            this.txtRQteStockMin.TabIndex = 26;
            // 
            // txtRDescription
            // 
            this.txtRDescription.Location = new System.Drawing.Point(203, 48);
            this.txtRDescription.Name = "txtRDescription";
            this.txtRDescription.Size = new System.Drawing.Size(155, 20);
            this.txtRDescription.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(383, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quantitee en Stock &Minimal";
            // 
            // txtRLibelle
            // 
            this.txtRLibelle.Location = new System.Drawing.Point(21, 48);
            this.txtRLibelle.Name = "txtRLibelle";
            this.txtRLibelle.Size = new System.Drawing.Size(157, 20);
            this.txtRLibelle.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(202, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "D&escription";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "&Libelle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1243, 669);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQteStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProduit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Johnson Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQteStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtRQteStockMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRQteStockMin;
        private System.Windows.Forms.TextBox txtRDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRLibelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

