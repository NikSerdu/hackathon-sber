import { Button } from "@salutejs/plasma-ui";
import { FC, useState } from "react";
import { useQuery } from "react-query";
import { Link } from "react-router-dom";
import { ApplicationService } from "../services/application/application.service";
import Application from "./Application";

const filters = [
  {
    id: 1,
    text: "Все",
  },
  {
    id: 2,
    text: "Новая",
  },
  {
    id: 3,
    text: "В работе",
  },
  {
    id: 4,
    text: "Дозапрос информации",
  },
  {
    id: 5,
    text: "На доработке",
  },
];

const HomePage: FC = () => {
  const {
    data: apps,
    isLoading,
    refetch,
  } = useQuery(["Get apps"], () => ApplicationService.getAllApplications());
  const [activeFilter, setActiveFilter] = useState(1);
  const [filteredData, setFIlteredData] = useState(apps);
  const filter = (id: number) => {
    setActiveFilter(id);
  };
  return (
    <div>
      <h1 className="text-4xl font-bold">Заявки</h1>
      <div className="flex glex-gap gap-5 mt-5">
        {filters.map((item) => (
          <Button
            text={item.text}
            key={item.id}
            view={activeFilter === item.id ? "primary" : "secondary"}
            onClick={() => filter(item.id)}
          />
        ))}
      </div>
      <div className="flex flex-col flex-gap gap-5 mt-5">
        {apps &&
          apps.map((item) => {
            return (
              <Link to={`/application/${item.id}`}>
                <Application data={item} />
              </Link>
            );
          })}
      </div>
    </div>
  );
};

export default HomePage;
