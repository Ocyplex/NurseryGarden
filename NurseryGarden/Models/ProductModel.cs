using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NurseryGarden.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("ProductName")]
        public string ProductName { get; set; }

        [DisplayName ("Description")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Price")]
        public decimal Price { get; set; }

    }
}
