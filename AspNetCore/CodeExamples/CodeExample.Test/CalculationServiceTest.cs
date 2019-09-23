using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CodeExample.Application;

namespace CodeExample.Test
{
    [TestClass]
    public class CalculationServiceTest
    {
        [TestMethod]
        public void Should_Return_current_Invoice_List_is_Ok()
        {
            var mockUserService = new Mock<IUserService>();
        }
    }
}
