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
            TypeClient.Enabled = true;
            btnChoix = "ajouter";
            btnOK.Enabled = true;
            btnAnnuler.Enabled = true;
            effacer();
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
            TypeClient.Enabled = true;
            btnChoix = "modifier";
            btnOK.Enabled = true;
            btnAnnuler.Enabled = true;
            //effacer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnChoix = "supprimer";
            btnOK.Enabled = true;
            btnAnnuler.Enabled = true;
            //effacer();

            textNum_client.Enabled = false;
            textNomClient.Enabled = false;
            textPrenomClient.Enabled = false;
            textSiretClient.Enabled = false;
            textAdresseFac.Enabled = false;
            textCodPostFac.Enabled = false;
            textCommuneFac.Enabled = false;
            textAdresseLiv.Enabled = false;
            textCodPostLiv.Enabled = false;
            textCommuneLiv.Enabled = false;
            textTelFixClient.Enabled = false;
            textTelMobClient.Enabled = false;
            textMail.Enabled = false;
            textCoef.Enabled = false;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textAdresseLiv_TextChanged(object sender, EventArgs e)
        {
            textAdresseLiv.MaxLength = 60;
            Regex myregex = new System.Text.RegularExpressions.Regex(@"^[0-9]{1,4}[a-zA-Zéàçèâêûîôäëüïö\,.' -]{1,30}$");
            if (myregex.IsMatch(textAdresseLiv.Text) == false)
            {
                textAdresseLiv.BackColor = Color.Salmon;

            }

            else
            {
                textAdresseLiv.BackColor = Color.LightGreen;

            }
        }

        private void textCodPostLiv_TextChanged(object sender, EventArgs e)
        {
            textCodPostLiv.MaxLength = 5;

            Regex myregex = new System.Text.RegularExpressions.Regex(@"^[0-9]{5}$");
            if (myregex.IsMatch(textCodPostLiv.Text) == false)
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
            textCommuneLiv.MaxLength = 50;
            Regex myregex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Zéàçèâêûîôäëüïö\- ]{2,30}$");
            if (myregex.IsMatch(textCommuneLiv.Text) == false)
            {
                textCommuneLiv.BackColor = Color.Salmon;

            }

            else
            {
                textCommuneLiv.BackColor = Color.LightGreen;

            }
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
                    cli.id_commercial = 1;
                }
                else
                {
                    cli.pro_ou_part_client = false;
                    cli.id_commercial = 2;
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
                cli.tel_mobile_client = textTelMobClient.Text;
                cli.mail_client = textMail.Text;
                cli.num_client = (int)ListClients.SelectedValue;
                if (pro.Checked == true)
                {
                    cli.pro_ou_part_client = true;
                    cli.id_commercial = 1;
                }
                else
                {
                    cli.pro_ou_part_client = false;
                    cli.id_commercial = 2;
                }


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
            ListClients.DataSource = repo.List();
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
            textAdresseFac.MaxLength = 60;
            Regex myregex = new System.Text.RegularExpressions.Regex (@"^[0-9]{1,4}[a-zA-Zéàçèâêûîôäëüïö\,.' -]{1,30}$");
            if (myregex.IsMatch(textAdresseFac.Text) == false)
            {
                textAdresseFac.BackColor = Color.Salmon;

            }

            else
            {
                textAdresseFac.BackColor = Color.LightGreen;

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textMail_TextChanged(object sender, EventArgs e)
        {
            Regex myregex = new Regex(@"([^@\s]+)@((?:[-a-z0-9]+\.)+[a-z]{2,})");
            if (myregex.IsMatch(textMail.Text) == false)
            {
                textMail.BackColor = Color.Salmon;
            }
            else
            {
                textMail.BackColor = Color.LightGreen;
            }
        }

        private void textCommuneFac_TextChanged(object sender, EventArgs e)
        {
            textCommuneFac.MaxLength = 50;
            Regex myregex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Zéàçèâêûîôäëüïö\- ]{2,30}$");
            if (myregex.IsMatch(textCommuneFac.Text) == false)
            {
                textCommuneFac.BackColor = Color.Salmon;

            }

            else
            {
                textCommuneFac.BackColor = Color.LightGreen;

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pro_CheckedChanged(object sender, EventArgs e)
        {
            textSiretClient.Enabled = true;
        }

        private void part_CheckedChanged(object sender, EventArgs e)
        {
            textSiretClient.Enabled = false;
        }

        private void btnHistComm_Click(object sender, EventArgs e)
        {
            Commandes fenetre = new WindowsFormsApplication4.Commandes();
            fenetre.Show();
        }
    }
}