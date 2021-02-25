using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_Nohai.Models
{
    public class Reducere
    {
        public int ID { get; set; }
        [Display(Name = "Tip reducere")]
        public string TipReducere { get; set; }

    }
}
