using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        private Basket basket;
        private DateTime creationDate;

        public Customer(Basket basket)
        {
            Basket = basket;
        }

        public Basket Basket
        {
            get => basket;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                basket = value;
            }
        }

        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
    }
}
