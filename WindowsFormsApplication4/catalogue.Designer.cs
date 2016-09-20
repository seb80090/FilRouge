namespace WindowsFormsApplication4
{
    partial class catalogue
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rubrique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ref_fourni_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_court_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_achat_ht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taux_tva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_ttc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(816, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 125;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(897, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 117;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 126;
            this.label3.Text = "Catalogue";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rubrique,
            this.ref_fourni_article,
            this.nom_court_article,
            this.prix_achat_ht,
            this.taux_tva,
            this.prix_ttc});
            this.dataGridView1.Location = new System.Drawing.Point(87, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(804, 341);
            this.dataGridView1.TabIndex = 127;
            // 
            // rubrique
            // 
            this.rubrique.HeaderText = "rubrique";
            this.rubrique.Name = "rubrique";
            // 
            // ref_fourni_article
            // 
            this.ref_fourni_article.HeaderText = "référence fournisseur de l\'article";
            this.ref_fourni_article.Name = "ref_fourni_article";
            this.ref_fourni_article.Width = 300;
            // 
            // nom_court_article
            // 
            this.nom_court_article.FillWeight = 200F;
            this.nom_court_article.HeaderText = "nom court de l\'article";
            this.nom_court_article.Name = "nom_court_article";
            // 
            // prix_achat_ht
            // 
            this.prix_achat_ht.HeaderText = "prix d\'achat hors taxes";
            this.prix_achat_ht.Name = "prix_achat_ht";
            // 
            // taux_tva
            // 
            this.taux_tva.HeaderText = "taux de tva";
            this.taux_tva.Name = "taux_tva";
            // 
            // prix_ttc
            // 
            this.prix_ttc.HeaderText = "prix de vente TTC";
            this.prix_ttc.Name = "prix_ttc";
            // 
            // catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 651);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "catalogue";
            this.Text = "catalogue";
            this.Load += new System.EventHandler(this.catalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubrique;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_fourni_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_court_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_achat_ht;
        private System.Windows.Forms.DataGridViewTextBoxColumn taux_tva;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_ttc;
    }
}