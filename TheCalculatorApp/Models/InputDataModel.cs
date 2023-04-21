using System.ComponentModel.DataAnnotations;

namespace TheCalculatorApp.Models
{
    public class InputDataModel
    {
        [Required(ErrorMessage="Please enter first number")]
        [Range(0, 1, ErrorMessage = "Please enter valid Number")]
        public decimal FirstNumber { get; set; }

        [Required(ErrorMessage = "Please enter second number")]
        [Range(0, 1, ErrorMessage = "Please enter valid Number")]
        public decimal SecondNumber { get; set; }

        
    }
}
