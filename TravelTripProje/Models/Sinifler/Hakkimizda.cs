using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sinifler
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string FotoURL { get; set; }
        public string Aciklama { get; set; }
    }
}