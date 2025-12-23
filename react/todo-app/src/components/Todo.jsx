import React from "react";
import { IoIosRemoveCircle } from "react-icons/io";
import { FaEdit } from "react-icons/fa";

function Todo() {
    return(
        <div className="todo">
            <h4 style={{paddingLeft:"10px"}}>Ben ilk todoyum</h4>
            <div>
                <IoIosRemoveCircle style={{fontSize:"25px", marginRight:"5px"}}></IoIosRemoveCircle>
                <FaEdit style={{fontSize:"25px",marginRight:"5px"}}></FaEdit>
            </div>
        </div>
    )
}

export default Todo;