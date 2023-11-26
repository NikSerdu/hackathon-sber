import { instance } from "../../api/api.instance";
import { IDecision } from "../../types/decision.interface";

export const DecisionService = {
  async setDecision(data: IDecision) {
    const { applicationId, ...rest } = data;
    const response = await instance<void>({
      url: `/decision/${applicationId}`,
      method: "POST",
      ...rest,
    });
    return response.data;
  },
};
