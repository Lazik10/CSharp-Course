using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MVCCalculator.Models
{
    public class Calculator
    {
        [Display(Name = "1. number")]
        public int Number1 { get; set; }
        
        [Display(Name = "2. number"), Range(1, 100, ErrorMessage = "Please insert number from 1 to 100.")]
        // Additional validations are for example: [StringLength(x)] or [RegularExpression("\\d+, ErrorMessage = "Invalid Code")]
        public int Number2 { get; set; }
        
        public double Result { get; set; }

        [Display(Name = "Operation")]
        public string? Operation { get; set; }

        public List<SelectListItem> PossibleOperations { get; set; }

        public Calculator()
        {
            PossibleOperations = new List<SelectListItem>();
            PossibleOperations.Add(new SelectListItem { Text = "Sečti", Value = "+", Selected = true });
            PossibleOperations.Add(new SelectListItem { Text = "Odečti", Value= "-" });
            PossibleOperations.Add(new SelectListItem { Text = "Vynásob", Value = "*" });
            PossibleOperations.Add(new SelectListItem { Text = "Vyděl", Value = "/" });
        }

        public void Compute()
        {
            switch (Operation)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "*":
                    Result = Number1 * Number2;
                    break;
                case "/":
                    Result = Number1 / Number2;
                    break;
                default:
                    break;
            }
        }
    }
}
