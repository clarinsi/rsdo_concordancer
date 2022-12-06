import React from 'react';
import ReactDOM from 'react-dom/client';
import { BrowserRouter } from 'react-router-dom';
import App from './App';
import i18n from './i18n';

import './index.scss';


// Set default language
const language = localStorage.getItem("language");
if (language) {
  i18n.changeLanguage(language);
}

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <BrowserRouter basename={window.baseAppPath}>
      <App />
    </BrowserRouter>
  </React.StrictMode>
);