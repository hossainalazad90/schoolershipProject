using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScholershipManagement.Models
{
    public class District
    {

        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Code { get; set; }

        public int? Population { get; set; }

        public int StateId { get; set; }

        [ForeignKey("StateId")]
        public virtual State State { get; set; }

        public ICollection<Upazila> Upazilas { get; set; }
    }
}