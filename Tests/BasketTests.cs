using Xunit.Sdk;

namespace Tests
{
    /// <summary>
    /// Test the Basket class.
    /// </summary>
    public class BasketTests
    {
        /// <summary>
        /// Tests both constructors and valids inital state.
        /// </summary>
        [Fact]
        public void CorrectInitialization()
        {
            // Arrange:
            Basket b1, b2;
            List<Product> products = new List<Product>()
            {
                new Product(),
                new Product()
            };   

            // Act:
            b1 = new Basket();
            b2 = new Basket(products);

            // Assert:
            Assert.NotNull(b1);
            Assert.NotNull(b2);
            Assert.NotNull(b1.Products);
            Assert.NotNull(b2.Products);
        }

        /// <summary>
        /// Tests whether or not an exception is generated when a basket is initialized with null, instead of a List<Product> object.
        /// </summary>
        [Fact]
        public void ThrowsOn_Initialization_NullForListOfProducts()
        {
            // Arrange:
            Basket b;
            Func<Basket> call;

            // Act:
            call = () => new Basket(null);

            // Assert:
            Assert.Throws<ArgumentNullException>(call);
        }

        [Fact]
        public void AddProduct()
        {
            // Arrange:
            Basket basket = new Basket();
            Product productToAdd = new Product();
            int expectedCount = 1;
            int actualCount;

            // Act:
            basket.Add(productToAdd);
            actualCount = basket.Products.Count;

            // Assert:
            Assert.Equal(expectedCount, actualCount);

        }
    }
}