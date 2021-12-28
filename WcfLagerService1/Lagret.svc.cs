using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfLagerService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Lagret : ILagret
    {
        public void HamtaVara(int id, int antal) // jag vill hämta ut vara, jag har antal och id
        {
            using (LagerModel db = new LagerModel())
            {
               var hämtadvara=db.Lager.Find(id); // har nu hämtat vara
                if (antal > hämtadvara.Antal) // jag vill kolla om lagersaldo är mer eller mindre än det affär vill beställa
                {                               //om antal de vill hämta ut är mer så går de ej, drf måste ja prata me grossist
                    Uttaget_GrossistServiceReference.GrossistClient klient = new Uttaget_GrossistServiceReference.GrossistClient();

                    // nu kan jag anropa grossistmetoden leverera, Antal har jag hämtat från databas så nu lägger jag till 10 där 
                    hämtadvara.Antal+= klient.Leverera();
                    // jag ska även minska från Antal det jag skickar till affär
                    hämtadvara.Antal -= antal;

                }
                else
                {
                    // Om det finns tillräckligt antal varor så kan jag bara minska saldo
                    hämtadvara.Antal -= antal;
                }
                db.SaveChanges();
            }
        }

        public List<Lager1> VisaAllaVaror() //Det här koden bakom interfacen
        {
            using (LagerModel db = new LagerModel())
            {
                List<Lager1> lagerkonto1 = new List<Lager1>();
                // behöver hämta från db
               var varulista = db.Lager.ToList();
                foreach (var l in varulista)
                {
                    Lager1 templager = new Lager1(); 
                    templager.Id = l.Id;
                    templager.Varunamn = l.Varunamn;
                    templager.Antal = l.Antal;
                    lagerkonto1.Add(templager);
                }
                return lagerkonto1; // här läser jag all data från databasen
            }


            // ska nu skapa metod som kollar lagersaldo, om saldo är mindre än det vi ska skicka så ska vi kommunicera med grossistservice.

        }
    }
}
