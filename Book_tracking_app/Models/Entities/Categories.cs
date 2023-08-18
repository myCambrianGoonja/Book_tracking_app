using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book_tracking_app.Models.Entities
{
    public class Categories
    {
        [Key]
        public string Name_Token { get; set; }
        
        public string Type { get; set; }
        
        public string Description { get; set; }
    }
}
