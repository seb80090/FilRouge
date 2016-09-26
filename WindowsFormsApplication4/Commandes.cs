using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace WindowsFormsApplication4
{
    public partial class Commandes : Form
    {
        commandesDAO reponse;
        ClientDAO cli;
        public Commandes()
        {
            reponse = new commandesDAO("server=. ;database= fil_rouge; integrated security= true  ");
            cli = new ClientDAO("server=. ; database= fil_rouge; integrated security= true ");
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Commandes_Load(object sender, EventArgs e)
        {
            //listCommande.DisplayMember = "Affichage";
            //listCommande.ValueMember = "num_commande";
            //listCommande.DataSource = reponse.List();



        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FicheClient ouvrirfiche = new FicheClient();
            ouvrirfiche.Show();

        }

        private void Commandes_Load_1(object sender, EventArgs e)
        {
            ChoixClient.DisplayMember = "Affichage";
            ChoixClient.ValueMember = "num_client";
            ChoixClient.DataSource = cli.List();
        }

        private void listCommande_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChoixClient_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listCommande.DisplayMember = "Affichage";
            listCommande.DataSource = reponse.List((int)ChoixClient.SelectedValue);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}