using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrainsAppl.Models;
using TrainsAppl.Models.DB;

namespace TrainsAppl.DAL
{
    public class TrainDBInitializer: DropCreateDatabaseIfModelChanges<TrainDBContext>
    {
        protected override void Seed(TrainDBContext context)
        {
            Train train;
            UserDB defaultUser = new UserDB
            {
                Username = "test",
                Password = "test123",
                Role = true
            };
            context.Users.Add(defaultUser);
            train = new Train
            {
                TrainNumber = 301,
                Type = "Пассажирский"
            };
            context.Trains.Add(train);
            train = new Train
            {
                TrainNumber = 851,
                Type = "Электропоезд"
            };
            context.Trains.Add(train);
            train = new Train
            {
                TrainNumber = 901,
                Type = "Товарный"
            };
            context.Trains.Add(train);
            context.SaveChanges();
            
        }

    }
}