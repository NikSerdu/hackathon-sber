import { Button, TextField } from "@salutejs/plasma-ui";
import { FC } from "react";
import { IReportBKI } from "../types/reportBKI.interface";
type TypeData = {
  data: IReportBKI;
};

const ReportBKI: FC<TypeData> = ({ data }) => {
  const { applicationId, id, obligations, score } = data;
  return (
    <>
      <div className="w-40 mt-5">
        <TextField defaultValue={score} placeholder="Скорбалл" />
      </div>
      <div className="">
        {obligations.map((item) => {
          return (
            <div className="mt-5">
              <h1 className="mb-5">Обязательство #{item.id}</h1>
              <div className="flex flex-gap flex-wrap gap-4">
                <TextField
                  defaultValue={item.type}
                  placeholder="Вид обязательств"
                />
                <TextField
                  defaultValue={item.startDate}
                  placeholder="Дата открытия"
                />
                <TextField
                  defaultValue={item.endDate}
                  placeholder="Дата закрытия"
                />
                <TextField
                  defaultValue={item.actualEndDate}
                  placeholder="Дата фактического закрытия"
                />
                <TextField defaultValue={item.role} placeholder="Роль" />
                <TextField defaultValue={item.status} placeholder="Статус" />
                <TextField defaultValue={item.amount} placeholder="Сумма" />
                <TextField
                  defaultValue={item.interestRate}
                  placeholder="Ставка %"
                />
                <TextField defaultValue={item.balance} placeholder="Остаток" />
                <TextField
                  defaultValue={item.overdueAmount}
                  placeholder="Сумма просрочки"
                />
                <TextField
                  defaultValue={item.overdueDays}
                  placeholder="Просрочка дней"
                />
              </div>
            </div>
          );
        })}
      </div>
      <Button text="Обновить данные" view="primary" className="mt-5" />
    </>
  );
};

export default ReportBKI;
