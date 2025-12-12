import React from "react";
import { useEffect } from "react";
import { useState } from "react";

function User(props) {

const [count, setCount] = useState(0);

useEffect( () => {
    console.log("count degistirildi")
}, [])

const {userName} = props;

    return(

        <div>
           <p>test {count}</p>
            <div>{userName}</div>
           <button onClick={() => setCount(count + 1)}>Click</button>
        </div>
    )
}


export default User;