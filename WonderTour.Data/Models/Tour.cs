using System.ComponentModel.DataAnnotations.Schema;

namespace WonderTour.Data.Models
{
    [Table("Tour")]
    public class Tour
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("price")]
        public double Price { get; set; }

        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

        public List<User> Users { get; set; } = new();
    }
}
