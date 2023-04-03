using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public String ProfilePictureUrl { get; set; }

        public String FullName { get; set; }

        public String Bio { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
