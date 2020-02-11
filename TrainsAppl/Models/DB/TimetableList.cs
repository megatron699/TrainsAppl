using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TrainsAppl.Models.DB;

namespace TrainsAppl.Models.DB
{
    public class TimetableList

    {
        [Key]
        public int Id { get; set; }
        
        public int StationId { get; set; }
        [ForeignKey("StationId")]
        public Station Station { get; set; }
        
        public int TimetableId { get; set; }
        [ForeignKey("TimetableId")]
        public Timetable Timetable { get; set; }

    }
}

