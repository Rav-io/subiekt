import React, { useState, useEffect } from 'react';

function InvoiceTable() {
    const [invoices, setInvoices] = useState([]);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        setLoading(true);
        fetch('http://localhost:4444/api/clients')
            .then(response => {
                if (!response.ok) {
                    throw new Error('Failed to fetch data');
                }
                return response.json();
            })
            .then(data => {
                setInvoices(data);
                setLoading(false);
            })
            .catch(error => {
                setError(error.message);
                setLoading(false);
            });
    }, []);

    if (loading) {
        return <div>Fetching data...</div>;
    }

    if (error) {
        return <div>Error fetching data: {error}</div>;
    }

    return (
        <div className="TableContainer">
            <h2>Invoices</h2>
            <table className="Table">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Numer</th>
                        <th>Kontrahent</th>
                        <th>Wartosc</th>
                    </tr>
                </thead>
                <tbody>
                    {invoices.map(invoice => (
                        <tr key={invoice.id}>
                            <td>{invoice.id}</td>
                            <td>{invoice.numer}</td>
                            <td>{invoice.kontrahent}</td>
                            <td>{invoice.wartosc}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );
}

export default InvoiceTable;
