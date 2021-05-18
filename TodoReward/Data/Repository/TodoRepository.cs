using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoReward.Model;

namespace TodoReward.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly IUserRepository _userRepository;

        public TodoRepository(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddTodo(Todo todo, Guid userId)
        {
            User user = _userRepository.GetUser(userId);

            if (user == null)
            {
                return;
            }

            user.Todos.Add(todo);

            // TODO: Save changes
        }

        public void DeleteTodo(Guid todoId, Guid userId)
        {
            User user = _userRepository.GetUser(userId);

            if (user == null)
            {
                return;
            }

            Todo todo = user.Todos.FirstOrDefault(t => t.Id == todoId);

            if (todo != null)
            {
                user.Todos.Remove(todo);
            }

            // TODO: Save changes
        }

        public Todo GetTodo(Guid todoId, Guid userId)
        {
            User user = _userRepository.GetUser(userId);

            if (user == null)
            {
                return null;
            }

            return user.Todos.FirstOrDefault(t => t.Id == todoId);
        }

        public List<Todo> GetTodos(Guid userId)
        {
            User user = _userRepository.GetUser(userId);

            if (user == null)
            {
                return null;
            }

            return user.Todos.ToList();
        }

        public void UpdateTodo(Todo todo, Guid userId)
        {
            User user = _userRepository.GetUser(userId);

            if (user == null)
            {
                return;
            }

            Todo todoToUpdate = user.Todos.FirstOrDefault(t => t.Id == todo.Id);

            if (todoToUpdate != null)
            {
                todoToUpdate.Description = todo.Description;
                todoToUpdate.TimeLeft = todo.TimeLeft;
                todoToUpdate.RepeatInterval = todo.RepeatInterval;
                todoToUpdate.Points = todo.Points;
            }

            // TODO: Save changes
        }
    }
}
