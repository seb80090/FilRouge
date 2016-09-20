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
    public partial class FicheClient : Form

    {
        ClientDAO repo;
        service_commercialDAO repo2;
        bool par_pro;
        
        public FicheClient()
        {
            repo = new ClientDAO("server=. ;database= fil_rouge; integrated security= true  ");
            repo2 = new service_commercialDAO("server=. ;database= fil_rouge; integrated security= true  ");
            InitializeComponent();
        }
        
        string btnChoix;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ListClients.DisplayMember = "Affichage";        
            ListClients.ValueMember = "num_client";
            ListClients.DataSource = repo.List();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox2.Visible = true;
                textAdresseLiv.Text = textAdresseFac.Text;
                textCodPostLiv.Text = textCodPostFac.Text;
                textCommuneLiv.Text = textCommuneFac.Text;
            }

            else
            {
                groupBox2.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void ListClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ListClients.SelectedIndex != -1)
            {

                int id = Convert.ToInt32(ListClients.SelectedValue);
                Client cli = repo.Find(id);
                textNum_client.Text = cli.num_client.ToString();
                textNomClient.Text = cli.nom_client;
                textPrenomClient.Text = cli.Prenom_client;
                textSiretClient.Text = cli.siret_client;
                textTelFixClient.Text = cli.tel_fix_client;
                textTelMobClient.Text = cli.tel_mobile_client;
                textMail.Text = cli.mail_client;               
                textAdresseFac.Text = cli.adresse_facturation_client;
                textCodPostFac.Text = cli.code_post_facturation_client;
                textCommuneFac.Text = cli.ville_facturation_client;
                textCoef.Text = cli.coef_client.ToString();

                if (cli.pro_ou_part_client == true)
                {
                    pro.Checked = true;
                    textSiretClient.Enabled = true;
                }
                else
                {
                    part.Checked = true;
                    textSiretClient.Enabled = false;

                }
                    

                //int commercial = 0;

                int id_commercial = Convert.ToInt32(ListClients.SelectedValue);
                service_commercial commercial  = repo2.Find(cli.id_commercial);
                text_prenom_commercial.Text = commercial.prenom_commercial;
                text_nom_commercial.Text = commercial.nom_commercial;
                text_tel_commercial.Text = commercial.tel_commercial;
                text_mail_commercial.Text = commercial.mail_commercial;
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            par_pro = true;
            ListClients.DisplayMember = "nom_client";
            ListClients.ValueMember = "num_client";
            ListClients.DataSource = repo.List_pro(par_pro);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            ListClients.DisplayMember = "nom_client";
            ListClients.ValueMember = "num_client";
            ListClients.DataSource = repo.List();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            par_pro = false;
            ListClients.DisplayMember = "nom_client";
            ListClients.ValueMember = "num_client";
            ListClients.DataSource = repo.List_pro(par_pro);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnChoix = "ajouter";
            btnOK.Enabled = true;
            btnAnnuler.Enabled = true;


            //effacer();
        }
        public void effacer()
        {
            textNum_client.Clear();
            textNomClient.Clear();
            textPrenomClient.Clear();
            textSiretClient.Clear();
            textAdresseFac.Clear();
            textCodPostFac.Clear();
            textCommuneFac.Clear();
            textAdresseLiv.Clear();
            textCodPostLiv.Clear();
            textCommuneLiv.Clear();
            textTelFixClient.Clear();
            textTelMobClient.Clear();
            textMail.Clear();
            //textCommercial.Clear();
            checkBox1.Checked = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnChoix = "Modifier";
            btnOK.Enabled = true;
            btnAnnuler.Enabled = true;
            //effacer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnChoix = "Supprimer";
            btnOK.Enabled = true;
            btnAnnuler.Enabled = true;
            //effacer();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textAdresseLiv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCodPostLiv_TextChanged(object sender, EventArgs e)
        {
            textCodPostLiv.MaxLength = 5;

            Regex myregex = new System.Text.RegularExpressions.Regex(@"^[0-9][0-9][0-9][0-9][0-9]");
            if (myregex.IsMatch(textCoef.Text) == false)
            {
                textCodPostLiv.BackColor = Color.Salmon;

            }

            else
            {
                textCodPostLiv.BackColor = Color.LightGreen;

            }
        }

        private void textCommuneLiv_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            btnAnnuler.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Client cli = new Client();
            //Si Ajouter
            if (btnChoix == "ajouter")
            {
                cli.nom_client = textNomClient.Text;
                cli.Prenom_client = textPrenomClient.Text;
                cli.adresse_livraison_client = textAdresseLiv.Text;
                cli.code_post_liv_client = textCodPostLiv.Text;
                cli.ville_liv_client = textCommuneLiv.Text;
                cli.adresse_facturation_client = textAdresseFac.Text;
                cli.code_post_facturation_client = textCodPostFac.Text;
                cli.ville_facturation_client = textCommuneFac.Text;
                cli.siret_client = textSiretClient.Text;
                cli.tel_fix_client = textTelFixClient.Text;
                cli.tel_mobile_client = textTelMobClient.Text;
                cli.mail_client = textMail.Text;
                cli.coef_client = Convert.ToDecimal(textCoef.Text);
                if (pro.Checked == true)

                {
                    cli.pro_ou_part_client = true;
                }
                cli.num_client = repo.AutoIncrement();

                repo.Insert(cli);
                MessageBox.Show("Client Ajouté", "Ajout", MessageBoxButtons.OK);

            }

            //SI Modifier
            if (btnChoix == "modifier")
            {
                cli.nom_client = textNomClient.Text;
                cli.Prenom_client = textPrenomClient.Text;
                cli.adresse_livraison_client = textAdresseLiv.Text;
                cli.code_post_liv_client = textCodPostLiv.Text;
                cli.ville_liv_client = textCommuneLiv.Text;
                cli.adresse_facturation_client = textAdresseFac.Text;
                cli.code_post_facturation_client = textCodPostFac.Text;
                cli.ville_facturation_client = textCommuneFac.Text;
                cli.siret_client = textSiretClient.Text;
                cli.tel_fix_client = textTelFixClient.Text;
                cli.tel_fix_client = textTelMobClient.Text;
                cli.mail_client = textMail.Text;
                cli.num_client = (int)ListClients.SelectedValue;

                repo.Update(cli);
                MessageBox.Show("Client Modifié", "Modification", MessageBoxButtons.OK);
            }
            //Si Supprimer
            if (btnChoix == "supprimer")
            {
                cli = repo.Find((int)ListClients.SelectedValue);
                repo.Delete(cli);
                MessageBox.Show("Client Supprimé", "Suppression", MessageBoxButtons.OK);
            }
            effacer();


        }
           


        private void textCommercial_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCommercial_Enter(object sender, EventArgs e)
        {
           
        }

        private void textSiretClient_TextChanged(object sender, EventArgs e)
        {
            textSiretClient.MaxLength = 13;

           Regex myregex = new System.Text.RegularExpressions.Regex(@"^[0-9]{13}$");
            if(myregex.IsMatch(textSiretClient.Text)==false)
            {
                textSiretClient.BackColor = Color.Salmon;
                
            }

            else
            {
                textSiretClient.BackColor = Color.LightGreen;
                
            }
        }

        private void text_prenom_commercial_Click(object sender, EventArgs e)
        {

        }

        private void textNomClient_TextChanged(object sender, EventArgs e)
        {
            textNomClient.MaxLength = 29;
            Regex myregex = new System.Text.RegularExpressions.Regex(@"^[a-zA-ZÀ-ÿ\s\’-]{1,29}$");
            if (myregex.IsMatch(textNomClient.Text) == false)
            {
                textNomClient.BackColor = Color.Salmon;

            }

            else
            {
                textNomClient.BackColor = Color.LightGreen;

            }
        }

        private void textNum_client_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrenomClient_TextChanged(object sender, EventArgs e)
        {
            textPrenomClient.MaxLength = 29;
            Regex myregex = new System.Text.RegularExpressions.Regex(@"^[a-zA-ZÀ-ÿ\s\'-]{1,29}$");
            if (myregex.IsMatch(textPrenomClient.Text) == false)
            {
                textPrenomClient.BackColor = Color.Salmon;
                
            }

            else
            {
                textPrenomClient.BackColor = Color.LightGreen;

            }
        }

        private void textTelFixClient_TextChanged(object sender, EventArgs e)
        {
            textTelFixClient.MaxLength = 10;

            Regex myregex = new System.Text.RegularExpressions.Regex(@"^[0-9]");
            if (myregex.IsMatch(textTelFixClient.Text) == false)
            {
                textTelFixClient.BackColor = Color.Salmon;

            }

            else
            {
                textTelFixClient.BackColor = Color.LightGreen;

            }
        }

        private void textTelMobClient_TextChanged(object sender, EventArgs e)
        {
            textTelMobClient.MaxLength = 10;

            Regex myregex = new System.Text.RegularExpressions.Regex(@"^[0-9]");
            if (myregex.IsMatch(textTelMobClient.Text) == false)
            {
                textTelMobClient.BackColor = Color.Salmon;

            }

            else
            {
                textTelMobClient.BackColor = Color.LightGreen;

            }
        }

        private void textCoef_TextChanged(object sender, EventArgs e)
        {
            textCoef.MaxLength = 10;

            Regex myregex = new System.Text.RegularExpressions.Regex(@"^[0-9][,.][0-9]");
            if (myregex.IsMatch(textCoef.Text) == false)
            {
                textCoef.BackColor = Color.Salmon;

            }

            else
            {
                textCoef.BackColor = Color.LightGreen;

            }
        }

        private void textCodPostFac_TextChanged(object sender, EventArgs e)
        {
            textCodPostFac.MaxLength = 5;

            Regex myregex = new System.Text.RegularExpressions.Regex(@"^[0-9]{5}$");
            if (myregex.IsMatch(textCodPostFac.Text) == false)
            {
                textCodPostFac.BackColor = Color.Salmon;

            }

            else
            {
                textCodPostFac.BackColor = Color.LightGreen;

            }
        }

        private void textAdresseFac_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textMail_TextChanged(object sender, EventArgs e)
        {
            Regex myregex = new Regex(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$");
            if (myregex.IsMatch(textMail.Text) == false)
            {
                textMail.BackColor = Color.Salmon;
            }
            else
            {
                textMail.BackColor = Color.LightGreen;
            }
        }
    }
}