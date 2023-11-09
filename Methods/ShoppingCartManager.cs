using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class ShoppingCartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Congrats. Shopping Cart Added : " + product.Name);
        }

        public void Add2(int Id, string Name, double Price, string Description, int UnitStock)
        {
            Console.WriteLine("Congrats. Shopping Cart Added2 : " + Name);
        }
    }
}
