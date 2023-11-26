import { IconArrowLeft } from "@salutejs/plasma-icons";
import { TabItem, Tabs } from "@salutejs/plasma-ui";
import { FC, useState } from "react";
import { useQuery } from "react-query";
import { Link, useParams } from "react-router-dom";
import { FormService } from "../services/form/form.service";
import { PDNService } from "../services/pdn/pdn.service";
import { ReportBKIService } from "../services/reportBKI/reportBKI.service";
import { RiskService } from "../services/risk/risk.service";
import Decision from "./Decision";
import Form from "./Form";
import Pdn from "./Pdn";
import ReportBKI from "./ReportBKI";
import Risks from "./Risks";
const parts = [
  {
    id: 1,
    text: "Анкета",
  },
  {
    id: 2,
    text: "Отчёт БКИ",
  },
  {
    id: 3,
    text: "ПДН",
  },
  {
    id: 4,
    text: "Риски",
  },
  {
    id: 5,
    text: "Итоговое решение",
  },
];

const ApplicationPage: FC = () => {
  const { appId } = useParams();
  const [part, setPart] = useState("Анкета");
  const {
    data: reportBKI,

    //@ts-ignore
  } = useQuery(["Get bki"], () => ReportBKIService.getByApplicationId(+appId));
  const {
    data: form,

    //@ts-ignore
  } = useQuery(["Get form"], () => FormService.getFormByAppId(+appId));

  const {
    data: pdn,

    //@ts-ignore
  } = useQuery(["Get pdn"], () => PDNService.getByApplicationId(+appId));

  const {
    data: risk,

    //@ts-ignore
  } = useQuery(["Get risk"], () => RiskService.getByApplicationId(+appId));
  const [tabIndex, setTabIndex] = useState(0);
  return (
    <div className="pb-5">
      <div className="flex flex-gap gap-5 pb-5 items-center">
        <div className="-ml-16">
          <Link to={"/"}>
            <IconArrowLeft />
          </Link>
        </div>
        <Tabs
          size="l"
          view="secondary"
          stretch={true}
          pilled={false}
          scaleOnPress={true}
          outlined={false}
          animated={true}
          index={tabIndex}
        >
          {parts.map((item) => (
            <TabItem
              key={item.id}
              isActive={part === item.text}
              onClick={() => {
                setPart(item.text);
                setTabIndex(item.id - 1);
              }}
            >
              {item.text}
            </TabItem>
          ))}
        </Tabs>
      </div>
      <div className="">
        {part === "Анкета" && (
          <div className="">
            <h1 className="text-3xl">Анкета</h1>
            {form && <Form data={form} />}
          </div>
        )}
        {part === "Отчёт БКИ" && (
          <div className="mt-5">
            <h1 className="text-3xl">Отчёт БКИ</h1>
            {reportBKI && <ReportBKI data={reportBKI} />}
          </div>
        )}
        {part === "ПДН" && (
          <div className="mt-5">
            <h1 className="text-3xl">ПДН</h1>
            {pdn && <Pdn pdn={pdn} />}
          </div>
        )}
        {part === "Риски" && (
          <div className="mt-5">
            <h1 className="text-3xl">Риски</h1>
            {risk && <Risks data={risk} />}
          </div>
        )}
        {part === "Итоговое решение" && (
          <div className="mt-5">
            <h1 className="text-3xl">Итоговое решение</h1>
            {appId && <Decision applicationId={+appId} />}
          </div>
        )}
      </div>
    </div>
  );
};

export default ApplicationPage;
