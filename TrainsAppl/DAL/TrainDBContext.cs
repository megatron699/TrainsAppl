using System.Data.Entity;
using TrainsAppl.Models.DB;

namespace TrainsAppl.DAL
{
    public class TrainDBContext:DbContext
    {
        static TrainDBContext()
        {
            Database.SetInitializer(new TrainDBInitializer());
        }

        public TrainDBContext() : base("TrainDBContext")
        {

        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        //    //base.OnModelCreating(modelBuilder);
        //}

        public DbSet<UserDB> Users { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Timetable> ArrivalDeparture { get; set; }
        public DbSet<TimetableList> Timetables { get; set; }
        public DbSet<Train> Trains { get; set; }

        //   public DbSet<Post> Posts { get; set; }
    }
}