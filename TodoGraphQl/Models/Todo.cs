using System;
using System.Collections.Generic;

namespace TodoGraphQl.Models;

public partial class Todo
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public bool Completed { get; set; }
}
