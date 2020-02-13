using System.ComponentModel.DataAnnotations;

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