using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace StudentMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StudentMVCContext(
                serviceProvider.GetRequiredService<DbContextOptions<StudentMVCContext>>()))
            {
                // Look for any Student.
                if (context.Student.Any())
                {
                    return; // DB has been seeded
                }
                context.Student.AddRange(
                    new Student
                    {
                        RollNumber = "S1",
                        Name = "Minh1"
                    },
                    new Student
                    {
                        RollNumber = "S2",
                        Name = "Minh2"
                    },
                    new Student
                    {
                        RollNumber = "S3",
                        Name = "Minh3"
                    },
                    new Student
                    {
                        RollNumber = "S4",
                        Name = "Minh4"
                    }
                );
                context.SaveChanges();
            }            
        }
    }
}
