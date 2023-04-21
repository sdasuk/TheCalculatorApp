using TheCalculatorApp.Models;
using TheCalculatorApp.Services;

namespace TheCalculatorAppTest
{
    public class CalculateServiceTest
    {
        [Theory]
        [InlineData(0.5, 0.5, 0.25)]
        [InlineData(1, 0.5, 0.5)]
        [InlineData(1, 1, 1.0)]
        public void CalculateUsingFirstFunction_ReturnOK(decimal param1, decimal param2, decimal expectedValue)
        {
            // Arrange  
            var inputData = new InputDataModel()
            {
                FirstNumber = param1,
                SecondNumber = param2
            };

            // Act  
            var result = new CalculateService().CalculateUsingFirstFunction(inputData);

            //Assert  
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(0.5, 0.5, 0.75)]
        [InlineData(0.75, 0.75, 0.9375)]
        [InlineData(1, 1, 1.0)]
        public void CalculateUsingSecondFunction_ReturnOK(decimal param1, decimal param2, decimal expectedValue)
        {
            // Arrange  
            var inputData = new InputDataModel()
            {
                FirstNumber = param1,
                SecondNumber = param2
            };

            // Act  
            var result = new CalculateService().CalculateUsingSecondFunction(inputData);

            //Assert  
            Assert.Equal(expectedValue, result);
        }
    }
}
