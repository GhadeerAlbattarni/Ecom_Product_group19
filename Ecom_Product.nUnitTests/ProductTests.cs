namespace Ecom_Product.nUnitTests
{

    public class ProductTests
    {
        //Test Cases For ProductID
        [Test]

        public void TestProductID_InputRange1to10000_RandomInputType()
        {

            // Arrange
            var product = new Product(119, "Product", 19, 19);
            //Price and stock set to 19 are arbitrary values chosen to test the product ID. (Values are based on Group No. 19)

            // Act
            var actual = product.ProductId;

            // Assert
            Assert.That(actual, Is.InRange(1, 10000));
        }



        [Test]
        public void TestProductID_InputRange1to10000_MinInputType()
        {

            // Arrange
            var product = new Product(1, "Product", 19, 19);

            // Act
            var actual = product.ProductId;

            // Assert
            Assert.That(actual, Is.EqualTo(1));
        }



        [Test]
        public void TestProductID_InputRange1to10000_MaxInputType()
        {

            // Arrange
            var product = new Product(10000, "Product", 19, 19);

            // Act
            var actual = product.ProductId;

            // Assert
            Assert.That(actual, Is.EqualTo(10000));
        }




        //Test Cases For Price  
        [Test]
        public void TestPrice_InputRange1to5000_RandomInputType()
        {

            // Arrange
            var product = new Product(19, "Product", 491, 19);

            // Act
            var actual = product.Price;

            // Assert
            Assert.That(actual, Is.InRange(1, 5000));
        }

        [Test]
        public void TestPrice_InputRange1to5000_MinInputType()
        {

            // Arrange
            var product = new Product(19, "Product", 1, 19);

            // Act
            var actual = product.Price;

            // Assert
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void TestPrice_InputRange1to5000_MaxInputType()
        {

            // Arrange
            var product = new Product(19, "Product", 5000, 19);

            // Act
            var actual = product.Price;

            // Assert
            Assert.That(actual, Is.EqualTo(5000));
        }

        //Test Cases For Stock 
        [Test]
        public void TestStock_InputRange1to100000_RandomInputType()
        {

            // Arrange
            var product = new Product(19, "Product", 19, 4119);

            // Act
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.InRange(1, 100000));
        }

        [Test]
        public void TestStock_InputRange1to100000_MinInputType()
        {

            // Arrange
            var product = new Product(19, "Product", 19, 1);

            // Act
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void TestStock_InputRange1to100000_MaxInputType()
        {

            // Arrange
            var product = new Product(19, "Product", 19, 100000);

            // Act
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(100000));
        }


        //Test Cases For ProductName
        [Test]
        public void TestProductName_StringInput()
        {

            // Arrange
            string productName = "exampleTestString";
            Product product = new Product(19, productName, 19, 19);
            string expected = "exampleTestString";

            // Act
            string actual = product.ProductName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestProductName_String_MinLength1()
        {

            // Arrange
            string productName = "e";
            Product product = new Product(19, productName, 19, 19);
            string expected = "e";

            // Act
            string actual = product.ProductName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestProductName_String_MaxLength1000()
        {

            // Arrange
            string productName = new string('e', 1000);
            Product product = new Product(19, productName, 19, 19);
            string expected = productName;

            // Act
            string actual = product.ProductName;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


        //Test Cases For method IncreaseStock()  
        [Test]
        public void IncreaseStock_Test_When_Adding_New_Stock()
        {

            // Arrange
            var product = new Product(19, "Product", 19, 19);
            var increaseAmount = 10;

            // Act
            product.StockIncrement(increaseAmount);
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(29));
        }

        [Test]
        public void IncreaseStock_Test_NoChange_When_AddedStockIsNull()
        {

            // Arrange
            var product = new Product(19, "Product", 19, 19);
            var increaseAmount = 0;

            // Act
            product.StockIncrement(increaseAmount);
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(19));
        }

        [Test]
        public void IncreaseStock_Test_StockValueStaysSame_WhenAmountIsNegative()
        {

            // Arrange
            var product = new Product(19, "Product", 19, 19);
            var increaseAmount = -19;

            // Act
            product.StockIncrement(increaseAmount);
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(19));
        }

        //Test Cases For method decreaseStock()
        [Test]

        public void DecreaseStock_Test_ReduceStock_WhenNewStockAdded()
        {

            // Arrange
            var product = new Product(19, "Product", 19, 19);
            var decreaseAmount = 1;

            // Act
            product.StockDecrement(decreaseAmount);
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(18));
        }

        [Test]
        public void DecreaseStock_Test_NoChange_WhenDecreasedStockIsNull()
        {

            // Arrange
            var product = new Product(19, "Product", 19, 19);
            var decreaseAmount = 0;

            // Act
            product.StockDecrement(decreaseAmount);
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(19));
        }

        [Test]
        public void DecreaseStock_Test_StockValueStaysSame_WhenAmountIsNegative()
        {

            // Arrange
            var product = new Product(19, "Product", 19, 19);
            var decreaseAmount = -19;

            // Act
            product.StockDecrement(decreaseAmount);
            var actual = product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(19));

        }
    }
}
