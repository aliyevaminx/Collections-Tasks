using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections_exceptions_task_4
{
    internal class Inventory
    {
        private Dictionary<string, int> products;

        public Inventory()
        {
            Products = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Products { get; set; }

        public void AddProduct(string name, int count)
        {
            if (!Products.ContainsKey(name))
                Products.Add(name, count);
            else
                Console.WriteLine("This product already exists");
        }

        public void RemoveProduct(string name)
        {
            if (Products.ContainsKey(name))
                Products.Remove(name);
            else
                Console.WriteLine("Product not found");
        }

        public void UpdateQuantity(string name, int count)
        {
            if (Products.ContainsKey(name))
                Products[name] = count;
            else
                Console.WriteLine("Product not found");
        }

        public void GetQuantityByProduct (string name)
        {
            if (Products.ContainsKey(name))
                Console.WriteLine($"Name: {name} Quantity: {Products[name]}");
            else
                Console.WriteLine("Product not found");
        }
    }
}
