using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScholershipManagement.Models
{
    public class Village
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Code { get; set; }

        public int? Population { get; set; }

        public int UnionPorisodId { get; set; }

        [ForeignKey("UnionPorisodId")]
        public virtual UnionPorisod UnionPorisod { get; set; }

        public ICollection<Ward> Wards { get; set; }
    }
}