using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_Nohai.Models
{
    public class Bilet
    {
        public int ID { get; set; }

        [Display(Name = "Echipa gazdă")]
        [Required, StringLength(70, MinimumLength = 3)]
        public string EchipaGazda { get; set; }

        [Display(Name = "Echipa oaspete")]
        [Required,  StringLength(70, MinimumLength = 3)]
        public string EchipaOaspete { get; set; }
        [Display(Name = "Data și ora meciului")]
       // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:MM}")]
        public DateTime DataJocului { get; set; }

        [Display(Name = "Bilete")]
        [Range(1, 99)]
        public int BileteCumparate { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(1, 900)]
        //[DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2} RON")]
        [Display(Name = "Preț")]
        public decimal Pret { get; set; }
        [Display(Name = "Nume și prenume")]
        public int ClientID { get; set; }

        public Client Client { get; set; } 



    }
}
