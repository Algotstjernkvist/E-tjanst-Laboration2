using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfLagerService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILagret
    {

        [OperationContract]
        // Här deklarerar vi metoderna som ska utföras i web service. 
        List<Lager1> VisaAllaVaror();

        [OperationContract] // En metod som kollar lagersaldo, men returnerar ingenting
        void HamtaVara(int id, int antal);

    }

    // Jag vill behandla tabell i db, så behöver skapa klass som har samma kolumner som db
    [DataContract]

    public partial class Lager1
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember] 
        public string Varunamn { get; set; }

        [DataMember]

        public int Antal { get; set; }
    }



}

