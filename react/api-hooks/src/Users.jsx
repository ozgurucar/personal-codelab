// import React, { useEffect, useState } from "react";
// import axios from "axios";

// function Users() {
//     const BASE_URL = "http://localhost:3000"

//     const getAllUsers = async () => {
//         let result = await axios.get(BASE_URL+"/users");
//         return result.data;
//     }

//     const [users, setUsers] = useState();

//     useEffect(() => {
//         setUsers(getAllUsers());
//     }, [])

//     return (
//         <div>
//             {users.map((user) => {
//                 <div key={user.id}> 
//                     <p>{user.name}</p>
//                     <p>{user.surname}</p>
//                 </div>
//             })}
//         </div>
//     )
// }

// export default Users;

import React, { useEffect, useState } from "react";
import axios from "axios";

function Users() {
    const BASE_URL = "http://localhost:3000";

    const [users, setUsers] = useState([]);

    const getAllUsers = async () => {
        const result = await axios.get(BASE_URL + "/users");
        return result.data;
    };

    useEffect(() => {
        const fetchUsers = async () => {
            const data = await getAllUsers();
            setUsers(data);
        };
        fetchUsers();
    }, []);

    return (
        <div>
            {users.map(user => (
                <div key={user.id} style= {
                 {
                    backgroundColor :"green"
                 }   
                }>
                    <p>{user.name}</p>
                    <p>{user.surname}</p>
                </div>
            ))}
        </div>
    );
}

export default Users;
