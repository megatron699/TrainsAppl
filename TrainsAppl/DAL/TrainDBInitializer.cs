using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrainsApp.Models;

namespace TrainsApp.DAL
{
    public class TrainDBInitializer: DropCreateDatabaseIfModelChanges<TrainDBContext>
    {
        protected override void Seed(TrainDBContext context)
        {
            UserDB defaultUser = new UserDB
            {
                Username = "test",
                Password = "test123",
                Role = true
            };
            context.Users.Add(defaultUser);
            context.SaveChanges();
        }

    }
}