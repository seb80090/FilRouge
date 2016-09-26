namespace WindowsFormsApplication4
{
    partial class Commandes
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
            this.ChoixClient = new System.Windows.Forms.ComboBox();
            this.listCommande = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChoixClient
            // 
            this.ChoixClient.FormattingEnabled = true;
            this.ChoixClient.Location = new System.Drawing.Point(354, 22);
            this.ChoixClient.Name = "ChoixClient";
            this.ChoixClient.Size = new System.Drawing.Size(282, 21);
            this.ChoixClient.TabIndex = 0;
            this.ChoixClient.SelectedIndexChanged += new System.EventHandler(this.ChoixClient_SelectedIndexChanged_1);
            // 
            // listCommande
            // 
            this.listCommande.FormattingEnabled = true;
            this.listCommande.Location = new System.Drawing.Point(146, 110);
            this.listCommande.Name = "listCommande";
            this.listCommande.Size = new System.Drawing.Size(490, 316);
            this.listCommande.TabIndex = 1;
            this.listCommande.SelectedIndexChanged += new System.EventHandler(this.listCommande_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selection Client";
            // 
            // Commandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCommande);
            this.Controls.Add(this.ChoixClient);
            this.Controls.Add(this.button1);
            this.Name = "Commandes";
            this.Text = "Commandes";
            this.Load += new System.EventHandler(this.Commandes_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChoixClient;
        private System.Windows.Forms.ListBox listCommande;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}