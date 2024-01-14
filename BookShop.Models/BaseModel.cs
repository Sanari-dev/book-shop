using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class BaseModel
    {
        [Key]
        public Guid? Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public BaseModel()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
    }
}
