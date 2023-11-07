using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentsWebApi.Models;

namespace StudentsWebApi.Data
{
    public class StudentsWebApiContext : DbContext
    {
        public StudentsWebApiContext (DbContextOptions<StudentsWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Assessment>Assessments { get; set; }
        public DbSet<Score> Scores { get; set; }
    }
}
