using Microsoft.Extensions.Logging;
using Moq;
using TheCalculatorApp.Controllers;
using TheCalculatorApp.Models;

namespace TheCalculatorAppTest
{
    public class ControllerTest
    {
        [Fact]
        public void Index_ModelValidateFail() 
        {
            // Arrange  
            var mockLogger = new Mock<ILogger<HomeController>>();
            var controller = new HomeController(mockLogger.Object);

            controller.ModelState.AddModelError("fakeError", "fakeError");

            InputDataModel inputData = null;

            // Act
            var result = controller.Index(inputData);

            //Assert
            Assert.False(controller.ModelState.IsValid);
        }
    }
}