import { FC } from "react";
import { IApplication } from "../types/application.interface";

type TypeData = {
  data: IApplication;
};

const Application: FC<TypeData> = ({ data }) => {
  const { amount, comment, date, decision, id, type } = data;
  return (
    <div className="h-40 bg-appGradient bg-cover rounded-2xl p-6 flex flex-col justify-between bg-opacity-10">
      <div className="flex justify-between">
        <h1 className="text-3xl font-medium">Заявка #{id}</h1>
        <span className="border border-green-600 rounded-2xl px-3 py-1">
          {type}
        </span>
      </div>
      <div className="flex justify-between">
        <span>Получена {date}</span>
        <a href="" className="bg-green-600 rounded-2xl px-3 py-1">
          Открыть
        </a>
      </div>
    </div>
  );
};

export default Application;
