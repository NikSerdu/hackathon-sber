export interface IRisk {
  hasCreditHistory: boolean;
  grade: string;
  oftenMicroloans: boolean;
  oftenTakeCreditForCredit: boolean;
  allowsDelays: boolean;
  hasDelay: boolean;
  riskOfNonPayments: boolean;
  riskOfMissingPayments: boolean;
  riskOfNonPaymentsLossIncome: boolean;
  increasingTheDebtBurden: boolean;
  riskLossIncome: boolean;
}
