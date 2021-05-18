using System;
using System.Collections.Generic;
using TodoReward.Data.Model;

namespace TodoReward.Data.Repository
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
