using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TrainsAppl.Models.DB
{
    public class Timetable
    {
        [Key]
        public int Id { get; set; }   
        public int TrainNumber { get; set; }
        public string Type { get; set; }
        public string Departue { get; set; }
        public string Destination { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public int WagonCount { get; set; }
        public string Set { get; set; }


    }
}