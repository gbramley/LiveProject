using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KingslandRedux.Models
{
    public class Produce
    {
        public int ProduceID { get; set; }
        public string ProduceName { get; set; }
        public decimal ProduceCost { get; set; }

        public virtual ICollection<Sandwich> Sandwiches { get; set; }
    }
}