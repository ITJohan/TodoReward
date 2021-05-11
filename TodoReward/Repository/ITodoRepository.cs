using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoReward.Model;

namespace TodoReward.Repository
{
    interface ITodoRepository
    {
        void AddTodo(Todo todo);
        void DeleteTodo(int id);
        Todo GetTodo(int id);
        List<Todo> GetTodos();
        void UpdateTodo(Todo todo);
    }
}
