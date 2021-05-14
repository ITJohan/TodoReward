using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoReward.Model;

namespace TodoReward.Repository
{
    interface ITodoRepository
    {
        void AddTodo(Todo todo, Guid userId);
        void DeleteTodo(Guid todoId, Guid userId);
        Todo GetTodo(Guid todoId, Guid userId);
        List<Todo> GetTodos(Guid userId);
        void UpdateTodo(Todo todo, Guid userId);
    }
}
