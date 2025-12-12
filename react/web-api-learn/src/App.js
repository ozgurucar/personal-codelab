import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { useEffect } from 'react';

function App() {
  const BASE_URL = "http://localhost:3005"

  const getAllUsers = async () => {
    let result = await axios.get(BASE_URL + "/users");
    console.log(result.data);
  }

  const getUserById = async (userId) => {
    let result = await axios.get(BASE_URL +"/users/"+userId);
    console.log(result.data);
  }  

  useEffect(() => {
    getAllUsers();
  }, [])

  return (
    <div>

    </div>
  );
}

export default App;
