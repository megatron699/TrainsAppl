using System.ComponentModel.DataAnnotations;

namespace TrainsAppl.Models.DB
{
    public class Train
    {
        [Key]
        public int Id { get; set; }
        public int TrainNumber { get; set; }
        public string Type { get; set; }
    }
}