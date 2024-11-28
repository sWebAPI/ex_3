﻿using ex3.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ex3.Repository
{
    public class TasksDBcontext : DbContext
    {
        public TasksDBcontext(DbContextOptions<TasksDBcontext> options) : base(options)
        {
        }

        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Project> Project { get; set; }

    }
}
