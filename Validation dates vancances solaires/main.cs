
using Validation_dates_vancances_solaires;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace Validation_dates_vancances_solaires
{
    public partial class main : Form
    {

        public class MyObject
        {
            public string NumeroDepartement { get; set; }
            public string NomDepartement { get; set; }
            public string Zone { get; set; }
        }
        public main()
        {
            InitializeComponent();
            this.labelZone.Text = "";
            this.labelNomDepartement.Text = "";
            this.labelErreurDepartement.Text = "";
            this.labelErreurNbrNuitees.Text = "";
            this.labelDateFinResa.Text = "";
            this.btnValidation.Enabled = false;
            this.dateDebutResa.MinDate = DateTime.Now;
            this.groupBoxResultat.Visible = false;
            this.labelResultat.Text = "";
        }


        private void CheckInfoDépartment(object sender, EventArgs e)
        {
            this.groupBoxResultat.Visible = false;
            if (this.textDepartement.Text == "" && this.TexBoxNbrNuitees.Text == "")
            {
                this.btnValidation.Enabled = false;
            }
        }


        private void GetInfoDépartment(object sender, EventArgs e)
        {
            string numeroDepartment;
            if (new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09" }.Contains(this.textDepartement.Text))
            {
                numeroDepartment = this.textDepartement.Text.Substring(1, 1);
            }
            else
            {
                numeroDepartment = this.textDepartement.Text;
            }


            string nomDepartment;
            string zone;
            //recherche si le département existe
            using (StreamReader r = new StreamReader("../DepartementsZones.json"))
            {
                string jsonDepartementZone = r.ReadToEnd();

                // Parser le fichier JSON
                JObject obj = JObject.Parse(jsonDepartementZone);

                // Rechercher la clé-valeur en utilisant la valeur de l'âge
                JToken objDepartement = obj["departement"].Where(t => t["NumeroDepartement"].ToString() == numeroDepartment).FirstOrDefault();
                if (objDepartement != null)
                {
                    nomDepartment = (string)objDepartement["NomDepartement"];
                    zone = (string)objDepartement["Zone"];
                    this.labelNomDepartement.Text = nomDepartment;
                    this.labelZone.Text = zone;
                    this.btnValidation.Enabled = true;
                    this.labelErreurDepartement.Text = "";

                }
                else
                {
                    this.labelErreurDepartement.Text = "Ce département n'existe pas";
                    this.labelZone.Text = "";
                    this.labelNomDepartement.Text = "";
                    this.btnValidation.Enabled = false;
                    this.textDepartement.Text = "";
                    this.groupBoxResultat.Visible = false;
                }


            }
            if (this.textDepartement.Text == "" || this.TexBoxNbrNuitees.Text == "")
            {
                this.btnValidation.Enabled = false;
                this.groupBoxResultat.Visible = false;
            }

        }
        private void PullDateFinResa(object sender, EventArgs e)
        {
            DateTime DTDebutResa = DateTime.Parse(this.dateDebutResa.Text);
            this.groupBoxResultat.Visible = false;
            this.labelResultat.Visible = false;
            if (this.TexBoxNbrNuitees.Text != "")
            {
                DateTime DTFinResa = DTDebutResa.AddDays(Convert.ToInt16(this.TexBoxNbrNuitees.Text));
                this.labelDateFinResa.Text = DTFinResa.ToString("dddd dd MMMM yyyy");
                this.btnValidation.Enabled = true;

            }
            else
            {
                this.labelDateFinResa.Text = "";
                this.btnValidation.Enabled = false;
            }
            if (this.textDepartement.Text == "" && this.TexBoxNbrNuitees.Text == "")
            {
                this.btnValidation.Enabled = false;
                this.labelResultat.Visible = false;
                this.groupBoxResultat.Visible = false;
            }

        }

        private void GetNbrNuitee(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(this.TexBoxNbrNuitees.Text, out value))
            {
                this.labelErreurNbrNuitees.Text = "";
                this.btnValidation.Enabled = true;
            }
            else
            {
                this.labelErreurNbrNuitees.Text = "Vous devez saisir un nombre entier";
                this.btnValidation.Enabled = false;
                this.labelResultat.Visible = false;
                this.groupBoxResultat.Visible = false;
            }
        }

        private async void btnValidation_Click(object sender, EventArgs e)
        {
            DateTime dtDebutResa = DateTime.Parse(this.dateDebutResa.Text);

            if (this.TexBoxNbrNuitees.Text != "")
            {
                this.labelResultat.Visible = true;
                DateTime dtFinResa = dtDebutResa.AddDays(Convert.ToInt16(this.TexBoxNbrNuitees.Text));
                this.labelDateFinResa.Text = dtFinResa.ToString("dddd dd MMMM yyyy");
                CallApiVacancesScolaires.Vacance vacance = await CallApiVacancesScolaires.CallApiVS(this.labelZone.Text, dtDebutResa, dtFinResa, this.TexBoxNbrNuitees.Text, this.labelZone.Text);
                if (vacance != null)
                {
                    this.groupBoxResultat.Visible = true;
                    this.labelResultat.BackColor = Color.LimeGreen;
                    this.labelResultat.Text = "Valide";
                    this.labelVSAnneeScolaire.Text = "Année scolaire " + vacance.AnneeScolaire;
                    this.labelVSDateDebut.Text = "Du " + vacance.DateDebut.Substring(0, 10);
                    this.labelVSDateFin.Text = "Au " + vacance.DateFin.Substring(0, 10); ;
                    this.labelVSZone.Text = vacance.Zone;
                    this.labelVSDescription.Text = vacance.Description;
                }
                else
                {
                    this.labelResultat.Text = "Non Valide";
                    this.labelResultat.BackColor = Color.Red;
                    this.groupBoxResultat.Visible = false;
                }

            }
            else
            {
                this.labelDateFinResa.Text = "";
                this.btnValidation.Enabled = false;
            }
        }
    }
}