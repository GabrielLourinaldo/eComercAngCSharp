using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LivrariaApi.Api.Models
{
    public class toDoContext : DbContext
    {
        public toDoContext(DbContextOptions<toDoContext> options) : base(options)
        {
            
        }

        public DbSet<Products> ToDoProducts { get; set; }
    }
}