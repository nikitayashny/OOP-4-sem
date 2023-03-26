using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Products
    {
        private int id_product { get; set; }
        private string name { get; set; }
        private string size { get; set; }
        private string color { get; set; }
        private int price { get; set; }
        private int amount { get; set; }
        private string picture { get; set; }

        public Products() { }
        public Products(string name, string size, string color, int price, int amount, string picture)
        {
            this.name = name;
            this.size = size;
            this.color = color;
            this.price = price;
            this.amount = amount;
            this.picture = picture;
        }
    }
}
