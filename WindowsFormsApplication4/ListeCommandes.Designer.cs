namespace WindowsFormsApplication4
{
    partial class ListeCommandes
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantHtCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantTtcCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(771, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 127;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(690, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 126;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateCommande,
            this.num_Client,
            this.Nom_Client,
            this.numCommande,
            this.MontantHtCommande,
            this.MontantTtcCommande});
            this.dataGridView1.Location = new System.Drawing.Point(105, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(602, 187);
            this.dataGridView1.TabIndex = 119;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 128;
            this.label1.Text = "Liste des commandes client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DateCommande
            // 
            this.DateCommande.HeaderText = "Date de Commande";
            this.DateCommande.Name = "DateCommande";
            // 
            // num_Client
            // 
            this.num_Client.HeaderText = "Numéro de Client";
            this.num_Client.Name = "num_Client";
            // 
            // Nom_Client
            // 
            this.Nom_Client.HeaderText = "Nom du client";
            this.Nom_Client.Name = "Nom_Client";
            // 
            // numCommande
            // 
            this.numCommande.HeaderText = "N° de commande";
            this.numCommande.Name = "numCommande";
            // 
            // MontantHtCommande
            // 
            this.MontantHtCommande.HeaderText = "Montant HT de la commande ";
            this.MontantHtCommande.Name = "MontantHtCommande";
            // 
            // MontantTtcCommande
            // 
            this.MontantTtcCommande.HeaderText = "Montant TTC de la Commande ";
            this.MontantTtcCommande.Name = "MontantTtcCommande";
            // 
            // ListeCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListeCommandes";
            this.Text = "ListeCommandes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantHtCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantTtcCommande;
    }
}