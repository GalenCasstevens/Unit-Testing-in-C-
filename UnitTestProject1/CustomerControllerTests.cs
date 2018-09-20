using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject1
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);
            
//            Not Found
            Assert.That(result, Is.TypeOf<NotFound>());
            
//            Not Found
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            
        }
    }
}