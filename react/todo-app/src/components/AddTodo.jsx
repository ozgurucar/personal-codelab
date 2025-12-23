import React from "react";

function AddTodo() {
    return (
        <div className="add-todo">
            <input type="text" placeholder="Todo giriniz" style={{
                border:"none", cursor:"pointer", outline:"none", borderBottom:"1px solid gray",
                width:"100%", padding:"10px 0", marginTop:"50px"
                }}></input>

            <button style={{backgroundColor:"gold", border:"none", padding:"7px", borderRadius:"7px", marginTop:"10px"}}>Todo oluştur</button>
        </div>
    )

}

export default AddTodo;