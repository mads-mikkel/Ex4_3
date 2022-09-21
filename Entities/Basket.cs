using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Basket
    {
        /// <summary>
        /// The list of products in this basket.
        /// </summary>
        private List<Product> products;

        /// <summary>
        /// Creates a new instance of Basket, with an empty list of products.
        /// </summary>
        public Basket()
        {
            products = new List<Product>();
        }

        /// <summary>
        /// Creates a new instance of Basket, with the provided list of products.
        /// </summary>
        /// <param name="products">The existing list of products to put in this basket.</param>
        public Basket(List<Product> products)
        {
            Products = products;
        }

        /// <summary>
        /// Gets the list of products in this basket.
        /// </summary>
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

        /// <summary>
        /// Adds a product to the basket.
        /// </summary>
        /// <param name="product">The product to add to this basket.</param>
        /// <exception cref="ArgumentNullException">When...</exception>
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