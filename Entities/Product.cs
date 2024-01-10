using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerecoes_Composicao.Enumeracoes_Composicao.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
