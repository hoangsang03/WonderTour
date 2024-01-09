using System.ComponentModel.DataAnnotations.Schema;

namespace WonderTour.Data.Models
{
    [Table("User")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("email")]
        public string Email { get; set; }

        public List<Tour> Tours { get; set; } = new();

    }
}
