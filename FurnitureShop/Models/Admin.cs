//using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Models
{
    public class Admin
    {
        [Key]

        public int Admin_Id { get; set; }
        public string Description { get; set; }
        public string Admin_LName { get; set; }
        public string Admin_FName { get; set; }
        public string ContactNumber { get; set; }

    }
}
