namespace NurseryGarden.Models
{
    public class BasketModel
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public List<ProductModel> myBasket { get; set; }
    }
}
