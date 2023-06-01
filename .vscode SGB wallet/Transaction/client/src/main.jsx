import React from "react";
import { createRoot } from "react-dom/client";

import App from "./App";
import { TransactionsProvider } from "./context/TransactionContext";
import "./index.css";

createRoot(document.getElementById("root")).render(
  <TransactionsProvider>
    <App />
  </TransactionsProvider>
);
