import React from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import InvoiceTable from './components/InvoiceTable';
import ClientTable from './components/ClientTable';
import './App.css';

function App() {
  return (
    <Router>
      <div>
        <div className="navigation">
          <Link to="/invoices" className="nav-button">Invoices</Link>
          <Link to="/clients" className="nav-button">Clients</Link>
        </div>

        <Routes>
          <Route path="/invoices" element={<InvoiceTable />} /> 
          <Route path="/clients" element={<ClientTable />} /> 
          <Route path="/" element={<div>
          </div>} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
