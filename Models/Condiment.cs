using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingslandRedux.Models
{
    public class Condiment
    {
        public int CondimentID { get; set; }
        public string CondimentName { get; set; }
        public decimal CondimentCost { get; set; }

        public virtual ICollection<Sandwich> Sandwiches { get; set; }
    }
}