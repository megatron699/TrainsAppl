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
            for (int i = 0; i < 20; i++)
            {
                train = new Train
                {
                    TrainNumber = 301 + i * 7,
                    Type = "Пассажирский"
                };
                context.Trains.Add(train);
            }
            for (int i = 0; i < 20; i++)
            {
                train = new Train
                {
                    TrainNumber = 851 + i * 2,
                    Type = "Электропоезд"
                };
                context.Trains.Add(train);
            }
            for (int i = 0; i < 20; i++)
            {
                train = new Train
                {
                    TrainNumber = 901 + i * 7,
                    Type = "Товарный"
                };
                context.Trains.Add(train);
            }
            context.SaveChanges();
        }
    }
}