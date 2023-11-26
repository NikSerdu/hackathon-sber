import { configureStore } from "@reduxjs/toolkit";
import { userSlice } from "./user/user.slice";

export const store = configureStore({
  reducer: {
    user: userSlice.reducer,
  },
});

export type RootState = ReturnType<typeof store.getState>;
