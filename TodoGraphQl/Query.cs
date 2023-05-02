using TodoGraphQl.Models;

public class Query
{
    private readonly TodoListContext _context;

    public Query(TodoListContext context)
    {
        _context = context;
    }
    public List<Todo> Read()
    {
        return _context.Todos.ToList();
    }

}

