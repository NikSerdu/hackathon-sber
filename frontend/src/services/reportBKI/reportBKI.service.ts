import { IReportBKI } from "../../types/reportBKI.interface";

export const ReportBKIService = {
  async getByApplicationId(applicationId: number) {
    // const response = await instance<IReportBKI>({
    //   url: `/report-bki/${applicationId}`,
    //   method: "GET",
    // });
    const data: IReportBKI = {
      applicationId: 1,
      id: 1,
      score: 100,
      obligations: [
        {
          id: 1,
          actualEndDate: "10.11.2022",
          amount: 1000000,
          balance: 150000,
          endDate: "25.11.2024",
          interestRate: 10,
          type: "Кредит",
          overdueAmount: 0,
          overdueDays: 0,
          reportId: 1,
          role: "Заемщик",
          startDate: "10.10.2015",
          status: "Закрыт",
        },
        {
          id: 2,
          actualEndDate: "10.11.2022",
          amount: 1000000,
          balance: 150000,
          endDate: "25.11.2024",
          interestRate: 10,
          type: "Кредит",
          overdueAmount: 0,
          overdueDays: 0,
          reportId: 1,
          role: "Заемщик",
          startDate: "10.10.2015",
          status: "Закрыт",
        },
      ],
    };
    return data;
    // return response.data;
  },
};
