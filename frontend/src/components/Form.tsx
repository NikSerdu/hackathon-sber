import { Button, TextField } from "@salutejs/plasma-ui";
import { FC } from "react";
import { IForm } from "../types/form.interface";

type TypeData = {
  data: IForm;
};

const Form: FC<TypeData> = ({ data }) => {
  const {
    additionalIncome,
    additionalIncomeDocument,
    applicationId,
    dateOfBirth,
    fullName,
    hasChildren,
    hasSavings,
    id,
    incomeDocument,
    isAdditionalIncomeConfirmed,
    maritalStatus,
    monthlyIncome,
    passport,
    position,
    registrationAddress,
    residenceAddress,
    savingsAmount,
    savingsCategory,
    workExperience,
    workplace,
  } = data;
  return (
    <>
      <div className="flex flex-wrap flex-gap gap-4 mt-5">
        <TextField placeholder="ФИО" defaultValue={fullName} />
        <TextField placeholder="Дата рождения" defaultValue={dateOfBirth} />
        <TextField
          placeholder="Серия и номер паспорта"
          defaultValue={passport}
        />

        <TextField
          placeholder="Адрес регистрации"
          defaultValue={registrationAddress}
        />

        <TextField
          placeholder="Адрес проживания"
          defaultValue={residenceAddress}
        />

        <TextField
          placeholder="Семейное положение"
          defaultValue={maritalStatus}
        />

        <TextField
          placeholder="Наличие детей"
          defaultValue={hasChildren ? "Да" : "Нет"}
        />

        <TextField placeholder="Место работы" defaultValue={workplace} />
        <TextField placeholder="Стаж работы" defaultValue={workExperience} />
        <TextField placeholder="Должность" defaultValue={position} />
        <TextField
          placeholder="Ежемесячный подтвержденный доход по месту
работы"
          defaultValue={monthlyIncome}
        />

        <TextField
          placeholder="Документ подтверждающий доход"
          defaultValue={incomeDocument}
        />

        <TextField
          placeholder="Ежемесячный доп.доход"
          defaultValue={additionalIncome}
        />

        <TextField
          placeholder="Дополнительный доход подтверждён"
          defaultValue={isAdditionalIncomeConfirmed ? "Да" : "Нет"}
        />

        <TextField
          placeholder="Источник доп.дохода"
          defaultValue={additionalIncomeDocument}
        />

        <TextField
          placeholder="Наличие сбережений на счетах в банке"
          defaultValue={hasSavings ? "Да" : "Нет"}
        />
        <TextField
          placeholder="Кол-во сбережений"
          defaultValue={savingsAmount}
        />
        <TextField
          placeholder="Категория сбережений"
          defaultValue={savingsCategory}
        />
      </div>
      <Button
        text="Запросить недостающие данные"
        view="primary"
        className="mt-5"
      />
    </>
  );
};

export default Form;
