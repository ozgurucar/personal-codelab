import React, { useEffect, useState } from "react";
import axios from "axios";

function User() {
    const BASE_URL = "http://localhost:3000"

    const [users, setUsers] = useState([]);

    const getAllUsers = async () => {
        const res = await axios.get(`${BASE_URL}/users`);
        return res.data;
    }

    useEffect(() => {
        const fetchUsers = async() => {
            const data = await getAllUsers();
            setUsers(data);
        }
        fetchUsers();
    }, []);

    return(
        <div>
            {users.map(u => (<p key={u.id}>{u.name} {u.password}</p>))}
        </div>
    );
}

export default User;