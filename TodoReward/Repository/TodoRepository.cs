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
            _todos = new List<Todo>
            {
                new Todo
                {
                    Id = 1,
                    Description = "Ring Siv",
                    Points = 10,
                    TimeLeft = 16,
                    RepeatInterval = 30
                },
                new Todo
                {
                    Id = 2,
                    Description = "Ring Solveig",
                    Points = 100,
                    TimeLeft = 4,
                    RepeatInterval = 30
                },
                new Todo
                {
                    Id = 3,
                    Description = "Træna",
                    Points = 10,
                    TimeLeft = 1,
                    RepeatInterval = 1
                },
                new Todo
                {
                    Id = 4,
                    Description = "Yoga",
                    Points = 10,
                    TimeLeft = 1,
                    RepeatInterval = 1
                }
            };
        }

        public void AddTodo(Todo todo)
        {
            _todos.Add(todo);
        }

        public void DeleteTodo(int id)
        {
            Todo todo = _todos.FirstOrDefault(t => t.Id == id);

            if (todo != null)
            {
                _todos.Remove(todo);
            }

        }

        public Todo GetTodo(int id)
        {
            return _todos.FirstOrDefault(t => t.Id == id);
        }

        public List<Todo> GetTodos()
        {
            return _todos.ToList();
        }

        public void UpdateTodo(Todo todo)
        {
            DeleteTodo(todo.Id);
            AddTodo(todo);
        }
    }
}
