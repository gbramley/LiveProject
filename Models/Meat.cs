using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingslandRedux.Models
{
    public class Meat
    {
        public int MeatID { get; set; }
        public string MeatName { get; set; }
        public decimal MeatCost { get; set; }

        public virtual ICollection<Sandwich> Sandwiches { get; set; }
    }
}