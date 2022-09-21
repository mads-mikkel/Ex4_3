using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Basket
    {
        private List<Product> products;

        public Basket()
        {
            products = new List<Product>();
        }

        public Basket(List<Product> products)
        {
            Products = products;
        }

        public List<Product> Products
        {
            get => products;
            private set
            {
                if (value is null)
                    throw new ArgumentNullException(nameof(value));
                products = value;
            }
        }

        public void Add(Product product)
        {
            if (product is null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            products.Add(product);
        }

        public void Remove(Product product)
        {
            if (product is null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            // TODO: consider using the bool return value from the List.Remove method.
            products.Remove(product);
        }
    }
}