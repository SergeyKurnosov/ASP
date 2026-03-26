using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Academy.Models;

namespace MVC_Academy.Data
{
    public class MVC_AcademyContext : DbContext
    {
        public MVC_AcademyContext (DbContextOptions<MVC_AcademyContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Academy.Models.Student> Students { get; set; } = default!;
        public DbSet<MVC_Academy.Models.Teacher> Teachers { get; set; } = default!;
        public DbSet<MVC_Academy.Models.Discipline> Disciplines { get; set; } = default!;
        public DbSet<MVC_Academy.Models.Direction> Directions { get; set; } = default!;
    }
}
