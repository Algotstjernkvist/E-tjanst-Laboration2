namespace WcfLagerService1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lager")]
    public partial class Lager
    {
        public int Id { get; set; }

        public string Varunamn { get; set; }

        public int Antal { get; set; }
    }
}
