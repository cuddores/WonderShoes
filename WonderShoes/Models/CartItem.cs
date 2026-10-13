using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonderShoes.Models
{
    public class CartItem
    {
        public Products Product { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
