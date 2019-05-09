using System;
using System.Collections.Generic;
using System.Text;
using Demo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infra.Data
{
    public class DemoDBContext : DbContext
    {
        public DemoDBContext(DbContextOptions option) : base(option)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
