import { Container } from "@salutejs/plasma-ui";
import { Route, Routes } from "react-router-dom";
import ApplicationPage from "./components/ApplicationPage";
import HomePage from "./components/HomePage";

function App() {
  return (
    <Container>
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/application/:appId" element={<ApplicationPage />} />
      </Routes>
    </Container>
  );
}

export default App;
