import { TextField } from "@salutejs/plasma-ui";
import { FC } from "react";

type TypeData = {
  pdn: number;
};

const Pdn: FC<TypeData> = ({ pdn }) => {
  return (
    <div className="mt-5 h-[60vh]">
      <TextField defaultValue={pdn} placeholder="ПДН" />
    </div>
  );
};

export default Pdn;
