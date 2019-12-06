using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScholershipManagement.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [MaxLength(50)]
        public string Code { get; set; }       

        [MaxLength(50)]
        public string Symbol { get; set; }

        public decimal? USDollarValue{ get; set; }

        public ICollection<Country> Countries { get; set; }
    }
}