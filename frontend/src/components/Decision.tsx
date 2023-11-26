import { Button, Switch, TextArea } from "@salutejs/plasma-ui";
import { FC, useState } from "react";
import { useMutation } from "react-query";
import { DecisionService } from "../services/decision/decision.service";

type TypeData = {
  applicationId: number;
};

const Decision: FC<TypeData> = ({ applicationId }) => {
  const [giveCredit, setGiveCredit] = useState(false);
  const [text, setText] = useState("");
  const { mutateAsync } = useMutation(
    ["Set decision"],
    () =>
      DecisionService.setDecision({
        comment: text,
        approve: giveCredit,
        applicationId: applicationId,
      }),
    {
      onSuccess: () => {},
    }
  );
  return (
    <div className="mt-5">
      <TextArea
        placeholder="Введите комментарий..."
        autoFocus={true}
        resize="none"
        defaultValue={text}
        onChange={(e) => setText(e.target.value)}
      />
      <Switch
        label="Выдать кредит:"
        checked={giveCredit}
        onChange={() => setGiveCredit(!giveCredit)}
        className="mt-5 w-52"
      />
      <div className="flex">
        <Button text="Отправить" view="primary" className="mt-5 ml-auto" />
      </div>
    </div>
  );
};

export default Decision;
