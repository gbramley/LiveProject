using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingslandRedux.Models
{
    public class Dairy
    {
        public int DairyID { get; set; }
        public string DairyName { get; set; }
        public decimal DairyCost { get; set; }

        public virtual ICollection<Sandwich> Sandwiches { get; set; }
    }
}