using Microsoft.EntityFrameworkCore;
using TodoGraphQl.Models;

public class Mutation
{
    private readonly TodoListContext _context;
    public Mutation(TodoListContext context)
    {
        _context = context;
    }
    public Todo Create(string description,bool completed)
    {
        Todo newTodo = new Todo();
        newTodo.Description = description;       
        if(newTodo.Description !=null)
        {
            newTodo.Completed = completed;
        }
        _context.Todos.Add(newTodo);
        _context.SaveChanges();
        return newTodo;
    }

    public Todo Update(int id,string? description , bool? completed)
    {
        var todo = _context.Todos.FirstOrDefault(o => o.Id == id);
        if (todo != null)
        {
            todo.Description = description ?? todo.Description;
            todo.Completed = completed ?? todo.Completed;
        }
        _context.Todos.Update(todo);
        _context.SaveChanges();
        return todo;
    }

    public Todo Delete(int id)
    {
        var todo = _context.Todos.FirstOrDefault(o => o.Id==id);
        if (todo != null)
        {
            _context.Todos.Remove(todo);
            _context.SaveChanges() ;
        }
        return todo;
    }
}

