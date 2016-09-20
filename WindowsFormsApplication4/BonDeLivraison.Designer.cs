namespace WindowsFormsApplication4
{
    partial class BonDeLivraison
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
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(619, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 118;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Items.AddRange(new object[] {
            "Adresse de livraison du client ",
            "adresse",
            "Code Postal",
            "Ville"});
            this.listBox4.Location = new System.Drawing.Point(39, 429);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(210, 108);
            this.listBox4.TabIndex = 116;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "Compagnie du client ",
            "adresse",
            "Code Postal",
            "Ville"});
            this.listBox3.Location = new System.Drawing.Point(39, 273);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(210, 121);
            this.listBox3.TabIndex = 115;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Article,
            this.Quantité});
            this.dataGridView1.Location = new System.Drawing.Point(318, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(400, 289);
            this.dataGridView1.TabIndex = 114;
            // 
            // Article
            // 
            this.Article.HeaderText = "Article";
            this.Article.Name = "Article";
            this.Article.Width = 300;
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.Name = "Quantité";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Date de la facture :",
            "N° de la facture : ",
            "N° de client :",
            "Date du paiement :",
            "Mode de paiement :",
            "Paiement différé :"});
            this.listBox2.Location = new System.Drawing.Point(318, 84);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(341, 108);
            this.listBox2.TabIndex = 113;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Ma Compagnie",
            "adresse",
            "Code Postal",
            "Ville"});
            this.listBox1.Location = new System.Drawing.Point(39, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 82);
            this.listBox1.TabIndex = 112;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 643);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 111;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 110;
            this.label1.Text = "Bon de livraison";
            // 
            // BonDeLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "BonDeLivraison";
            this.Text = "BonDeLivraison";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
    }
}