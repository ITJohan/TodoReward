using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoReward.Model;

namespace TodoReward.Repository
{
    interface ITodoRepository
    {
        bool AddTodo(Todo todo);
        List<Todo> GetTodos();
        Todo GetTodo(int id);
        bool UpdateTodo(Todo todo);
        bool DeleteTodo(int id);
    }
}
