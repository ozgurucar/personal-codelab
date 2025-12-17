import axios from "axios";
import { useEffect, useState } from "react";
import "../css/currency.css"
import { FaArrowCircleRight } from "react-icons/fa";

function Currency() {

    const BASE_URL = import.meta.env.VITE_BASE_URL
    const API_KEY = import.meta.env.VITE_API_KEY

    const [currencies, setCurrencies] = useState([]);
    const [toCurrency, setToCurrency] = useState("AUD");
    const [fromCurrency, setFromCurrency] = useState("AUD");
    const [toAmount,setToAmount] = useState(0);
    const [fromAmount, setFromAmount] = useState(0);


    const convert = async () => {
        const result = await axios.get(`${BASE_URL}?apikey=${API_KEY}&base_currency=${fromCurrency}`)
        const ratio = result.data.data[toCurrency]
        setToAmount(Number(fromAmount * ratio).toFixed(2))
    }

    useEffect(() => {
        const fetchCurrencies = async () => {
            const result = await axios.get(`${BASE_URL}?apikey=${API_KEY}`);
            setCurrencies(result.data.data);
        };

        fetchCurrencies();
    }, []);

    return (
        <div className="currency-main">
            <div className="header">
                <h1>Döviz Kuru Uygulaması</h1>
            </div>

            <div className="currency-body">
                <div className="currency-selections">
                    <div className="from-currency">
                        <input type="number" className="amount" value={fromAmount} onChange={(e) => {
                            setFromAmount(e.target.value)
                        }}></input>
                        <select className="from-selection" value ={fromCurrency} onChange={(e) => {
                            setFromCurrency(e.target.value)
                        }}>
                            {Object.keys(currencies).map((currency) => (
                                <option key={currency} value={currency}>
                                    {currency}
                                </option>
                            ))}
                        </select>
                    </div>
                    <FaArrowCircleRight style={{ fontSize: "30px", marginTop: "50px" }}></FaArrowCircleRight>
                    <div className="to-currency">
                         <select className="to-selection" value={toCurrency} onChange={(e) => {
                            setToCurrency(e.target.value)
                        }}>
                            {Object.keys(currencies).map((currency) => (
                                <option key={currency} value={currency}>
                                    {currency}
                                </option>
                            ))}
                        </select>
                        <input type="number" className="result" value={toAmount}></input>
                    </div>
                </div>
                <button onClick={() => convert()}>Çevir</button>
            </div>
      
        </div>
    )
}

export default Currency;