using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace TrainsAppl.Models.DB
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public int Platform { get; set; }
        public int Way { get; set; }
        public string Schema { get; set; }
        

    }
}