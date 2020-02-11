using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrainsAppl.Models.DB
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public int Platform { get; set; }
        public int Way { get; set; }
        

    }
}