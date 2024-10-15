using System.ComponentModel.DataAnnotations;

namespace Investment_Calculator.Models
{
    public class FutureValueModel
    {

        [Required(ErrorMessage = "Please enter a monthly investment")]
        [Range(1, 500, ErrorMessage = "Monthly investment must be between 1 to 500")]
        public decimal? MonthlyInvestment { get; set; }

        [Range(17,25,ErrorMessage = "Yearly investment rate must be between 17 to 25")]
        [Required(ErrorMessage ="Please enter a yearly interest rate")]
        public decimal? YearlyInvestment { get; set; }

        [Required(ErrorMessage ="Please enter a number of years")]
        public int? Year { get; set; }

        public decimal? CalculateFutureValue() {
            int? months = Year * 12;
            decimal? monthlyInvestmentRate = YearlyInvestment / 12 / 100;
            decimal? futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) *
                        (1 + monthlyInvestmentRate);
            }
            return futureValue;
        }

    }
}
