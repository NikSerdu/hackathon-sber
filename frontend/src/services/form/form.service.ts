import { IForm } from "../../types/form.interface";

export const FormService = {
  async getFormByAppId(applicationId: number) {
    // const response = await instance<IForm>({
    //   url: `/profiles/${applicationId}`,
    //   method: "GET",
    // });
    const data: IForm = {
      id: 1,
      fullName: "Иванов Иван Иванович",
      passport: "1010 393939",
      registrationAddress: "г.Москва",
      residenceAddress: "г.Тверь",
      hasChildren: true,
      additionalIncome: 100000,
      additionalIncomeDocument: "Есть",
      applicationId: 1,
      dateOfBirth: "10.12.2003",
      hasSavings: true,
      incomeDocument: "Есть",
      isAdditionalIncomeConfirmed: true,
      maritalStatus: "женат",
      monthlyIncome: 30000,
      position: "Директор",
      savingsAmount: 1000000,
      savingsCategory: "Категория",
      workExperience: 2,
      workplace: "ООО Технологии",
    };
    return data;
    // return response.data;
  },
};
