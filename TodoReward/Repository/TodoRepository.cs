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
            _todos.Add(todo);
            return true;
        }

        public bool DeleteTodo(int id)
        {
            Todo todo = _todos.FirstOrDefault(t => t.Id == id);

            if (todo != null)
            {
                _todos.Remove(todo);
                return true;
            }

            return false;
        }

        public Todo GetTodo(int id)
        {
            return _todos.FirstOrDefault(t => t.Id == id);
        }

        public List<Todo> GetTodos()
        {
            return _todos.ToList();
        }

        public bool UpdateTodo(Todo todo)
        {
            DeleteTodo(todo.Id);
            AddTodo(todo);
            return true;
        }
    }
}
