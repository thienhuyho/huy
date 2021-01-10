namespace QLSV.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classroom>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Classroom)
                .HasForeignKey(e => e.IDClassroom);
        }
    }
}
