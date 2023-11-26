import { Container } from "@salutejs/plasma-ui";
import { FC, PropsWithChildren } from "react";
import Header from "./Header";

const Layout: FC<PropsWithChildren<unknown>> = ({ children }) => {
  return (
    <div>
      <Container>
        <Header />
        {children}
      </Container>
    </div>
  );
};

export default Layout;
