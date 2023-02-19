using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_dates_vancances_solaires
{
    internal class CallApiVacancesScolaires
    {
        public class Vacance
        {
            public string Description { get; set; }
            public string Zone { get; set; }
            public string DateDebut { get; set; }
            public string DateFin { get; set; }
            public string AnneeScolaire { get; set; }
        }
        public static async Task<Vacance> CallApiVS(string numeroDepartment,DateTime dateDebutResa, DateTime dateFinResa,string nbrNuitees, string zone)
        {
            using (HttpClient client = new HttpClient())
            {
      
                string anneDate = dateDebutResa.Year.ToString();
                List<string> listeZone = new List<string> { "A","B","C"};
                if (listeZone.Contains(zone))
                {
                    zone = "Zone+" + zone;
                }


                string stringUri = "https://data.education.gouv.fr/api/records/1.0/search/?dataset=fr-en-calendrier-scolaire&q=&lang=fr&rows=1000&facet=description&facet=start_date&facet=end_date&facet=zones&facet=annee_scolaire&";
                stringUri += "refine.zones=" + zone;
                stringUri += "&refine.start_date=" + anneDate;


                Uri uri = new Uri("https://data.education.gouv.fr/api/records/1.0/search/?dataset=fr-en-calendrier-scolaire&q=&lang=fr&rows=1000&facet=description&facet=start_date&facet=end_date&facet=zones&facet=annee_scolaire&refine.zones=Zone+A&refine.start_date=2022");


                HttpResponseMessage responseVS = await client.GetAsync(stringUri);

                if (responseVS.IsSuccessStatusCode)
                {
                    string responseBodyVS = await responseVS.Content.ReadAsStringAsync();
                    JObject joVS = (JObject)JsonConvert.DeserializeObject(responseBodyVS);
                    JToken jtVacancesScolaires = joVS["records"];
                    foreach (JObject joVacancesScolaires in jtVacancesScolaires)
                    {
                        DateTime dateDebutPeriodeVS =  DateTime.Parse(joVacancesScolaires["fields"]["start_date"].ToString());
                        DateTime dateFinPeriodeVS = DateTime.Parse(joVacancesScolaires["fields"]["end_date"].ToString());
                        if (dateDebutResa >= dateFinPeriodeVS && dateFinResa <= dateFinPeriodeVS)
                        {
                            Vacance vacance = new Vacance();
                            vacance.DateDebut = joVacancesScolaires["fields"]["start_date"].ToString();
                            vacance.DateFin = joVacancesScolaires["fields"]["end_date"].ToString();
                            vacance.AnneeScolaire = joVacancesScolaires["fields"]["annee_scolaire"].ToString();
                            vacance.Zone = joVacancesScolaires["fields"]["zones"].ToString();
                            vacance.Description = joVacancesScolaires["fields"]["description"].ToString();
                            return vacance;
                        }
                    }
                    return null;
                }
                else
                {
                    return null;
                }
            }

        }
    }
}
