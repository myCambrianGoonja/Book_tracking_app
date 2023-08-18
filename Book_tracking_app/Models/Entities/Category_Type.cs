using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Book_tracking_app.Models.Entities
{
    public class Category_Type {
        [Key]
        public string Type{ get; set; }
        public string Name{ get; set; }
    }
}