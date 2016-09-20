namespace WindowsFormsApplication4
{
    partial class ListeProduitsCommandés
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.date_commande_fourni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_court_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte_commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date_commande_fourni,
            this.Nom,
            this.nom_court_article,
            this.qte_commande});
            this.dataGridView1.Location = new System.Drawing.Point(78, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(957, 519);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Articles commandés\r\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1041, 679);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 111;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(960, 679);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 110;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // date_commande_fourni
            // 
            this.date_commande_fourni.HeaderText = "date de commande au fournisseur";
            this.date_commande_fourni.Name = "date_commande_fourni";
            this.date_commande_fourni.Width = 200;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "référence fournisseur";
            this.Nom.Name = "Nom";
            this.Nom.Width = 300;
            // 
            // nom_court_article
            // 
            this.nom_court_article.HeaderText = "nom court de l\'article";
            this.nom_court_article.Name = "nom_court_article";
            this.nom_court_article.Width = 200;
            // 
            // qte_commande
            // 
            this.qte_commande.HeaderText = "quantité commandée";
            this.qte_commande.Name = "qte_commande";
            this.qte_commande.Width = 200;
            // 
            // ListeProduitsCommandés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 714);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListeProduitsCommandés";
            this.Text = "ListeProduitsCommandés";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_commande_fourni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_court_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte_commande;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}