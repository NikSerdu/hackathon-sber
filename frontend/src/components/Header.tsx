import { Button, Header as HeaderC } from "@salutejs/plasma-ui";
import { FC } from "react";
const Header: FC = () => {
  return (
    <div className="mb-5">
      <HeaderC logo="/logo.png" logoAlt="Logo">
        <div className="flex items-center  flex-gap gap-2">
          <Button>Войти</Button>
          {/* <Button className="h-20 w-20">
              <IconAvatar size="s" />
            </Button> */}
        </div>
      </HeaderC>
    </div>
  );
};

export default Header;
