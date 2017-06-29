using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingslandRedux.Models
{
    public class ToGo
    {
        public int ToGoID { get; set; }
        public string ToGoName { get; set; }
        public decimal ToGoCost { get; set; }

        public virtual ICollection<Sandwich> Sandwiches { get; set; }
    }
}