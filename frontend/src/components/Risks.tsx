import { Checkbox, TextField } from "@salutejs/plasma-ui";
import { FC } from "react";
import { IRisk } from "../types/risk.interface";

type TypeData = {
  data: IRisk;
};

const Risks: FC<TypeData> = ({ data }) => {
  const {
    allowsDelays,
    grade,
    hasCreditHistory,
    hasDelay,
    increasingTheDebtBurden,
    oftenMicroloans,
    oftenTakeCreditForCredit,
    riskLossIncome,
    riskOfMissingPayments,
    riskOfNonPayments,
    riskOfNonPaymentsLossIncome,
  } = data;
  return (
    <div className="mt-5 flex">
      <div className="">
        <Checkbox
          className="checkbox"
          checked={hasCreditHistory}
          label="Наличие кредитной истории"
        />

        <Checkbox
          className="checkbox"
          checked={oftenMicroloans}
          label="Часто использует микрозаймы"
        />
        <Checkbox
          className="checkbox"
          checked={oftenTakeCreditForCredit}
          label="Часто берёт кредиты для закрытия других"
        />
        <Checkbox
          className="checkbox"
          checked={allowsDelays}
          label="Допускает просрочки"
        />
        <Checkbox
          className="checkbox"
          checked={hasDelay}
          label="Имеет просрочки"
        />
        <Checkbox
          className="checkbox"
          checked={riskOfNonPayments}
          label="Риск неплатежей по кредиту ввиду недостаточной платежеспособности"
        />
        <Checkbox
          className="checkbox"
          checked={riskOfMissingPayments}
          label="Риск отсутствия выплат по кредиту ввиду отсутствия у клиента официального источника дохода"
        />
        <Checkbox
          className="checkbox"
          checked={riskOfNonPaymentsLossIncome}
          label="Риск неплатежей по кредиту ввиду потери дополнительного дохода"
        />
        <Checkbox
          className="checkbox"
          checked={increasingTheDebtBurden}
          label="Риск увеличения долговой нагрузки ввиду наличия в отчете БКИ действующих обязательств"
        />
        <Checkbox
          className="checkbox"
          checked={riskLossIncome}
          label="Риск потери/снижения дохода"
        />
      </div>
      <div className="">
        <TextField placeholder="Оценка" defaultValue={grade} className="" />
      </div>
    </div>
  );
};

export default Risks;
