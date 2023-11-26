import { IApplication } from "../../types/application.interface";

export const ApplicationService = {
  async getAllApplications() {
    // const response = await instance<IApplication[]>({
    //   url: `/applications`,
    //   method: "GET",
    // });
    const data: IApplication[] = [
      {
        id: 1,
        amount: 1000000,
        comment: "Комментарий",
        date: "25.11.2023",
        decision: "Одобрить",
        type: "В обработке",
      },
      {
        id: 2,
        amount: 1000000,
        comment: "Комментарий",
        date: "25.11.2023",
        decision: "Одобрить",
        type: "В обработке",
      },
      {
        id: 3,
        amount: 1000000,
        comment: "Комментарий",
        date: "25.11.2023",
        decision: "Одобрить",
        type: "Новая",
      },
    ];
    return data;

    // return response.data;
  },
};
