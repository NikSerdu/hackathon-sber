namespace SberCase.Models
{
    public class Risk
    {
        /*
         hasCreditHistory: true,
      grade: "хорошая",
      oftenMicroloans: true,
      oftenTakeCreditForCredit: true,
      allowsDelays: true,
      hasDelay: true,
      riskOfNonPayments: true,
      riskOfMissingPayments: true,
      riskOfNonPaymentsLossIncome: true,
      increasingTheDebtBurden: true,
      riskLossIncome: true,
         */
        public int Id { get; set; } = 1;
        public bool HasCreditHistory { get; set; } = true;
        public string Grade { get; set; } = "good";
        public bool OftenMicroloans { get; set; } = true;
        public bool OftenTakeCreditForCredit { get; set; } = true;
        public bool AllowsDelays { get; set; } = true;
        public bool HasDelay { get; set; } = true;
        public bool RiskOfNonPayments { get; set; } = true;
        public bool RiskOfMissingPayments { get; set; } = true;
        public bool RiskOfNonPaymentsLossIncome { get; set; } = true;
        public bool IncreasingTheDebtBurden { get; set; } = true;
        public bool RiskLossIncome { get; set; } = true;
    }
}
