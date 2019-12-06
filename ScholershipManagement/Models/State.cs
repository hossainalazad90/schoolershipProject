using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScholershipManagement.Models
{
    public class State
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Display(Name ="State/Division")]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Code { get; set; }

        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        public int? Population { get; set; }

        public ICollection<District> Districts { get; set; }


    }
}