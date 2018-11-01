using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentMVC.Models
{
    public class StudentMVCContext : DbContext
    {
        public StudentMVCContext (DbContextOptions<StudentMVCContext> options)
            : base(options)
        {
        }

        public DbSet<StudentMVC.Models.Student> Student { get; set; }
    }
}
