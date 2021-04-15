using Mocking;
using Moq;
using NUnit.Framework;

namespace MockTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestImplementedMethod()
        {
            ///I don't understand why you need to use Mocking.Repository class. 
            ///Isn't that an external reference?
            ///Creates a fake object of Repository
            ///The fake object is then stored into the Mock<Repository>
            var mock = new Mock<Repository>();
            //Passes the mock object that was created to the Business class
            //does not pass the Repository to access the methods
            Business business = new Business(mock.Object);
            //Test case using the mock object for the implemented method Sum
            Assert.AreEqual(4, business.Addition(2, 2));
        }

        [Test]
        public void TestNotImplmentedMethod()
        {
            var mock = new Mock<Repository>();
            //Because Repository.Sub is not finished, I need to pass the 
            //constructor dependancy injection from Business class
            //set up the Sub method and return the values I want to be reutrned
            //self means the same as this. in the Repository class
            //I tell it what value to return
            mock.Setup(self => self.Sub(3, 2)).Returns(1);
            //Passes the mock object that was created to the Business class
            Business business = new Business(mock.Object);

            Assert.AreEqual(1, business.Subtraction(3, 2));

        }
    }
}