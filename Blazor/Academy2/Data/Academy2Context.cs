using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academy2.Components.Model;

namespace Academy2.Data
{
    public class Academy2Context : DbContext
    {
        public Academy2Context (DbContextOptions<Academy2Context> options)
            : base(options)
        {
        }

        public DbSet<Academy2.Components.Model.Direction> Directions { get; set; } = default!;
        public DbSet<Academy2.Components.Model.Group> Groups { get; set; } = default!;
        public DbSet<Academy2.Components.Model.Student> Students { get; set; } = default!;
        public DbSet<Academy2.Components.Model.Teacher> Teachers { get; set; } = default!;
        public DbSet<Academy2.Components.Model.Discipline> Disciplines { get; set; } = default!;
        public DbSet<Academy2.Components.Model.TeacherDisciplineRelation> TeachersDisciplinesRelation { get; set; } = default!;
    }
}
