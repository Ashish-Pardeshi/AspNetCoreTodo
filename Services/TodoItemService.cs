﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class TodoItemService : ITodoItemService
    {
        public Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync()
        {
            // Return an array of TodoItems
            IEnumerable<TodoItem> items = new[]
            {
                new TodoItem
                {
                    Title = "Learn ASP.NET Core",
                    DueAt = DateTimeOffset.Now.AddDays(1)

                },

                new TodoItem
                {
                    Title = "Build awesome apps",
                    DueAt = DateTimeOffset.Now.AddDays(2)
                }
            };
            return Task.FromResult(items);
        }
    }
}
