using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoReward.Model;

namespace TodoReward.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private IList<Todo> _todos;

        public TodoRepository()
        {
            _todos = new List<Todo>();
        }

        public bool AddTodo(Todo todo)
        {
            Console.WriteLine("AddTodo");
            _todos.Add(todo);
            return true;
        }

        public bool DeleteTodo(int id)
        {
            throw new NotImplementedException();
        }

        public Todo GetTodo(int id)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetTodos()
        {
            throw new NotImplementedException();
        }

        public bool UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
