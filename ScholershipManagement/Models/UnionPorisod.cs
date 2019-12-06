using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScholershipManagement.Models
{
    public class UnionPorisod
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Code { get; set; }

        public int? Population { get; set; }

        public int UpazilaId { get; set; }

        [ForeignKey("UpazilaId")]
        public virtual Upazila Upazila { get; set; }
    }
}