import axios from "axios";

export const getContentType = () => ({
  "Content-Type": "application/json",
});

export const instance = axios.create({
  baseURL: "https://localhost:5001/",
  headers: getContentType(),
});
