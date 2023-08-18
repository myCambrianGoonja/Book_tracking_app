using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Book_tracking_app.Models.Entities
{
    public class Books {
        [Key]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
    }
}