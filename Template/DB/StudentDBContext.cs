using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.Models;

namespace Template.DB
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options)
          : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
