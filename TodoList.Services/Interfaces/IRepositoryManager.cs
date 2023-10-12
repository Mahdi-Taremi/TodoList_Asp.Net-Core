﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Services.Interfaces
{
    public interface IRepositoryManager
    {
        ITodoRepository Todo { get; }
        Task SaveAsync();

    }
}
