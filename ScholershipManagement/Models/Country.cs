using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScholershipManagement.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [MaxLength(2)]
        public string ISOCode2 { get; set; }
        [MaxLength(3)]
        public string ISOCode3 { get; set; }

        public decimal? Area { get; set; }

        public int? Population { get; set; }
        [MaxLength(50)]
        public string Capital { get; set; }

       
        public int CurrencyId { get; set; }

        [ForeignKey("CurrencyId")]
        public virtual Currency Currency { get; set; }

        public ICollection<State> States { get; set; }

    }
}