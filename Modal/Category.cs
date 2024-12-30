using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomm.Modal
{
    [Table("Category")]
    public class Category
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public int DisplayId { get; set; }

    }
}
