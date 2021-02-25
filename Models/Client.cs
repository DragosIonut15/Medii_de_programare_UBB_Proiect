using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_Nohai.Models
{
    public class Client
    {
        public int ID { get; set; }

        [Display(Name = "Nume și prenume")]
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", ErrorMessage = "Numele clientului trebuie sa fie de forma 'Nume si prenume'"), Required, StringLength(50,MinimumLength = 3)]
        public String NumeClient { get; set; }

        public int ReducereID { get; set; }

        public Reducere Reducere { get; set; }


    }
}
