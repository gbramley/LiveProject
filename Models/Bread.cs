using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingslandRedux.Models
{
    public class Bread
    {
        public int BreadID { get; set; }
        public string BreadName { get; set; }
        public decimal BreadCost { get; set; }

        public virtual ICollection<Sandwich> Sandwiches { get; set; }
    }
}