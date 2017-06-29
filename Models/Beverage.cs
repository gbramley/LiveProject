using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingslandRedux.Models
{
    public class Beverage
    {
        public int BeverageID { get; set; }
        public string BeverageName { get; set; }
        public decimal BeverageCost { get; set;}

        public virtual ICollection<Sandwich> Sandwiches { get; set; }
    }
}