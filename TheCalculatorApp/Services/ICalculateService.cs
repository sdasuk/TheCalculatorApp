using TheCalculatorApp.Models;

namespace TheCalculatorApp.Services
{
    public interface ICalculateService
    {
        decimal CalculateUsingFirstFunction(InputDataModel model);

        decimal CalculateUsingSecondFunction(InputDataModel model);
    }
}
