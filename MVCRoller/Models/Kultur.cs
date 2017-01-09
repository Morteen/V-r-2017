using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRoller.Models
{
    public class Kultur
    {
        [Required]
        public int KulturId { get; set; }
        [Required(ErrorMessage = "Avdeling må spesifiseres")]
        [Display(Name = "Avdeling")]
        public String TypeAktivitet { get; set; }
        [Required(ErrorMessage = "Leder må noteres")]
        [Display(Name ="Navn på leder")]
        public String Ansvarlig { get; set; }
        [Display(Name ="Navn på datasystem")]
        public String System { get; set; }
        [Display(Name ="Dato for siste endring")]
        public DateTime EndretDato { get; set; }
        [Display(Name ="Plassering av master data")]
        public string MasterData { get; set; }
    }
}