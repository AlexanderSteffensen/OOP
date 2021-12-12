using System;
using System.Security.Cryptography.X509Certificates;
using Core;
using Core.Transactions;
using Xunit;
using Xunit.Abstractions;

namespace Test
{
    public class UnitTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }


        [Theory]
        [InlineData(1, "alex", "alex@hotmail.com")]
        [InlineData(2, "andersand", "ande.rs@an-d.com")]
        [InlineData(3, "mickey", "min-mail@mic-key.dk")]
        [InlineData(4, "postmanden", "po_st@man-den.com")]
        public void UserTest(int id, string username, string email)
        {
            //act
            User testUser = new User(id, "Alexander", "Steffensen", username, 112.21m, email);
            
            //assert
            Assert.Equal(username, testUser.Username);
            Assert.Equal(email, testUser.Email);
        }

        [Theory]
        [InlineData(1, "sodavand")]
        [InlineData(2, "monster")]
        [InlineData(3, "kaffe")]
        public void ProductTest(int id, string name)
        {
            //act
            Product testProduct = new Product(id, name, 12.3m, true);
            
            //assert
            Assert.Equal(id, testProduct.ID);
            Assert.Equal(name, testProduct.Name);
        }

        [Fact]
        public void BuyTransactionTest()
        {
            //Arrange
            StregSystem stregSystem = new StregSystem();

            User testUser = new User(20, "Alex", "Steffensen", "alexstef", 2000m, "alex@gmail.com");

            decimal userInitialBalance = testUser.Balance;

            Product testProduct = new Product(7654, "Drikkeyoghurt", 200m, true);

            BuyTransaction buyTransaction = new BuyTransaction(1, testUser, DateTime.Now, testProduct, 3);
            
            _testOutputHelper.WriteLine(testUser.Balance.ToString());
            
            //Act
            buyTransaction.Execute();
            _testOutputHelper.WriteLine(testUser.Balance.ToString());
            //Assert
            Assert.Equal(userInitialBalance - (3 * testProduct.Price), testUser.Balance);
        }

        [Fact]
        public void InsertCashTransactionTest()
        {
            //Arrange
            StregSystem stregSystem = new StregSystem();

            User testUser = new User(20, "Alex", "Steffensen", "alexstef", 2000m, "alex@gmail.com");
            
            decimal userInitialBalance = testUser.Balance;

            InsertCashTransaction insertCashTransaction = new InsertCashTransaction(2, testUser, DateTime.Now, 2000m);

            //Act
            insertCashTransaction.Execute();
            
            //Assert
            Assert.Equal(userInitialBalance + insertCashTransaction.Price, testUser.Balance);
        }
        
    }
}