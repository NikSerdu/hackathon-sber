export interface IForm {
  id: number;
  fullName: string;
  dateOfBirth: string;
  passport: string;
  registrationAddress: string;
  residenceAddress: string;
  maritalStatus: string;
  hasChildren: boolean;
  workplace: string;
  workExperience: number;
  position: string;
  monthlyIncome: number;
  incomeDocument: string;
  additionalIncome: number;
  isAdditionalIncomeConfirmed: boolean;
  additionalIncomeDocument: string;
  hasSavings: boolean;
  savingsCategory: string;
  savingsAmount: number;
  applicationId: number;
}
