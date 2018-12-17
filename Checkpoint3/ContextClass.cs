using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp {
    public class Context : DbContext {
        public DbSet<ToDo> toDos { get; set; }

        override
        protected void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite ("Filename=./ToDo.db");
        }
    }
}
