import React, { useState, useEffect } from "react";
import axios from "axios";
import "../css/currencySelector.css"

function CurrencySelector() {

    const [currencies, setCurrencies] = useState([])
    const [currentCurrency, setCurrentCurrency] = useState({
  code: "USD",
  name: "US Dollar"
});

    const [currencyValue, setValue] = useState(0)
    const [result, setResult] = useState(0)

    const calculate = async () => {
        const _result =  await axios.get(`https://api.freecurrencyapi.com/v1/latest?apikey=fca_live_UvcGrhGGZ3NQGUIR8bSoPcWBHKgGThLmaFppf5yp&currencies=${currentCurrency.code}&base_currency=USD`);
        const rate = _result.data.data[currentCurrency.code];
        setResult(rate * currencyValue)

    }

    useEffect(
      () => {
        const fetchCurrencies = async () => {
            const result = await axios.get(`https://api.freecurrencyapi.com/v1/currencies?apikey=fca_live_UvcGrhGGZ3NQGUIR8bSoPcWBHKgGThLmaFppf5yp&currencies=EUR%2CUSD%2CCAD`);
            console.log(result.data)
            setCurrencies(
            Object.values(result.data.data).map(currency => ({
                code: currency.code,
                name: currency.name
            })));
        }
        fetchCurrencies();
      } , []
    ); 


    useEffect(
        () => {
            console.log(currentCurrency.code);
        } , [currentCurrency]
    )

    return (
        <div className="currency-container">
    <select id="currency-selector" size={currencies.length}>
       {currencies.map(c => ( <option key={c.code} onClick={() => setCurrentCurrency(c) }>{c.name}</option> ))}
    </select>

    <div className="labels">
        <div>
            <h3>Base Currency</h3>
            <input type="number" onChange={(e) => calculate(e.target.value)}></input>
            <p>{currentCurrency.code}</p>
        </div>
        <div>
            <h3>To</h3>
            <p>USD</p>
        </div>
        <div>
            <button onClick={() => calculate()}>Calculate</button>
            <h2>Result: {result.toFixed(2)}</h2>
        </div>
    </div>
    <div> 
        <p>
            {currencies.map(c => () => {
                <p>c</p>
            } )}
        </p>
    </div>
</div>
    )
}

export default CurrencySelector