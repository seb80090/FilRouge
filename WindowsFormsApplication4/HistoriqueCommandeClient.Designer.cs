namespace WindowsFormsApplication4
{
    partial class HistoriqueCommandeClient
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox19 = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.numCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantHtCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontantTtcCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(910, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 118;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(829, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 117;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(342, 96);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(207, 21);
            this.richTextBox1.TabIndex = 114;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Nom";
            // 
            // richTextBox19
            // 
            this.richTextBox19.Location = new System.Drawing.Point(97, 96);
            this.richTextBox19.Name = "richTextBox19";
            this.richTextBox19.Size = new System.Drawing.Size(150, 21);
            this.richTextBox19.TabIndex = 112;
            this.richTextBox19.Text = "";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 104);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 111;
            this.label21.Text = "N° de client";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCommande,
            this.DateCommande,
            this.MontantHtCommande,
            this.MontantTtcCommande});
            this.dataGridView1.Location = new System.Drawing.Point(292, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(401, 230);
            this.dataGridView1.TabIndex = 110;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 25);
            this.label3.TabIndex = 119;
            this.label3.Text = "Historique de commandes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numCommande
            // 
            this.numCommande.HeaderText = "N° de commande";
            this.numCommande.Name = "numCommande";
            // 
            // DateCommande
            // 
            this.DateCommande.HeaderText = "Date de Commande";
            this.DateCommande.Name = "DateCommande";
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
            // HistoriqueCommandeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HistoriqueCommandeClient";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantHtCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontantTtcCommande;
    }
}