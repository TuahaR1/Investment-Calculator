namespace Investment_Calculator.Models
{
    public class FutureValueModel
    {
        public decimal MonthlyInvestment { get; set; }
        public decimal YearlyInvestment { get; set; }

        public int Year { get; set; }

        public decimal CalculateFutureValue() {
            int months = Year * 12;
            decimal monthlyInvestmentRate = YearlyInvestment / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) *
                        (1 + monthlyInvestmentRate);
            }
            return futureValue;
        }

    }
}
