import { text } from "@salutejs/plasma-tokens";
import { salutejs_sber__dark } from "@salutejs/plasma-tokens/themes"; // Или один из списка: salutejs_eva__dark, salutejs_joy__dark, salutejs_eva__light, salutejs_sber__light
import { createGlobalStyle } from "styled-components";

const DocumentStyle = createGlobalStyle`
    html {
        color: ${text};
    }
`;
const ThemeStyle = createGlobalStyle(salutejs_sber__dark);

export const GlobalStyle = () => (
  <>
    <DocumentStyle />
    <ThemeStyle />
  </>
);
