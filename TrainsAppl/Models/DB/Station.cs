using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace TrainsAppl.Models.DB
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public int PassCount { get; set; }
        public int HeavyCount { get; set; }
        public string Schema { get; set; }
        

    }
}