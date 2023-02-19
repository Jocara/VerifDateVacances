
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
        }


        private async void CheckInfoDépartment(object sender, EventArgs e)
        {
            if (this.textDepartement.Text == "" && this.TexBoxNbrNuitees.Text =="")
            {
                this.btnValidation.Enabled = false;
            }
        }


            private async void GetInfoDépartment(object sender, EventArgs e)
        {
            string numeroDepartment = this.textDepartement.Text;
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
                }


            }
            if (this.textDepartement.Text == "" || this.TexBoxNbrNuitees.Text == "")
            {
                this.btnValidation.Enabled = false;
            }

        }
        private void PullDateFinResa(object sender, EventArgs e)
        {
            DateTime DTDebutResa = DateTime.Parse(this.dateDebutResa.Text);

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
            }
        }
        
        private async void btnValidation_Click(object sender, EventArgs e)
        {
            DateTime dtDebutResa = DateTime.Parse(this.dateDebutResa.Text);

            if (this.TexBoxNbrNuitees.Text != "")
            {
                DateTime dtFinResa = dtDebutResa.AddDays(Convert.ToInt16(this.TexBoxNbrNuitees.Text));
                this.labelDateFinResa.Text = dtFinResa.ToString("dddd dd MMMM yyyy");
                CallApiVacancesScolaires.Vacance vacance = await CallApiVacancesScolaires.CallApiVS(this.labelZone.Text, dtDebutResa, dtFinResa, this.TexBoxNbrNuitees.Text, this.labelZone.Text);
                if (vacance != null)
                {
                    this.labelResultat.Text = "ok";
                }
                else
                {
                    this.labelResultat.Text = "KO";
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