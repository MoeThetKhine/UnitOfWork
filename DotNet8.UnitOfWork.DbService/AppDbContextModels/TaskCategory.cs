﻿using System;
using System.Collections.Generic;

namespace DotNet8.UnitOfWork.DbService.AppDbContextModels;

public partial class TaskCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public bool? IsDelete { get; set; }

    public virtual ICollection<ToDoList> ToDoLists { get; set; } = new List<ToDoList>();
}
