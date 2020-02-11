using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrainsAppl.Models;
using TrainsAppl.Models.DB;

namespace TrainsApp.DAL
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

        public DbSet<UserDB> Users { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Timetable> ArrivalDeparture { get; set; }
        public DbSet<TimetableList> Timetables { get; set; }
        public DbSet<Train> Trains { get; set; }

        //   public DbSet<Post> Posts { get; set; }
    }
}