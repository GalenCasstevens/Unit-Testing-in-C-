using NUnit.Framework;
using TestNinja.Fundamentals;

namespace UnitTestProject1
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            
            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo(("a")));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            
            // use a delegate for methods that throw an exception
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }
    }
}