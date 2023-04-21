using TheCalculatorApp.Models;

namespace TheCalculatorApp.Services
{
    public class CalculateService: ICalculateService
    {
        public decimal CalculateUsingFirstFunction(InputDataModel model)
        {
            return model.FirstNumber * model.SecondNumber;
        }

        public decimal CalculateUsingSecondFunction(InputDataModel model)
        {
            decimal value = model.FirstNumber + model.SecondNumber - CalculateUsingFirstFunction(model);

            return value;
        }


    }
}
