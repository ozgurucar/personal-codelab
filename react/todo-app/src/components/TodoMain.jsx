import React from "react";

import "../App.css"
import AddTodo from "./AddTodo";
import Todo from "./Todo";

function TodoMain() {
    return (
        <div className="todo-main">
            <AddTodo></AddTodo>
            <Todo></Todo>
            <Todo></Todo>
            <Todo></Todo>

        </div>
    )
}

export default TodoMain