import { IObligation } from "./obligation.interface";

export interface IReportBKI {
  id: number;
  score: number;
  obligations: IObligation[];
  applicationId: number;
}
