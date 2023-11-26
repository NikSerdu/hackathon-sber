import { IRisk } from "../../types/risk.interface";

export const RiskService = {
  async getByApplicationId(applicationId: number) {
    // const response = await instance<IReportBKI>({
    //   url: `/risk/${applicationId}`,
    //   method: "GET",
    // });
    const data: IRisk = {
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
    };
    return data;
    // return response.data;
  },
};
