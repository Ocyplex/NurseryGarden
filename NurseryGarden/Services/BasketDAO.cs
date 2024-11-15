using NurseryGarden.Models;
using System.Collections.Generic;

namespace NurseryGarden.Services
{
    public class BasketDAO
    {
        public List<BasketModel>AllBasket = new List<BasketModel>();

        public List<ProductModel> ShowBasket(UserModel userModel)
        {
            List<BasketModel> UserBasket = AllBasket.Where(j => userModel.Id == j.Id).ToList();
            try
            {
                return UserBasket.First().myBasket;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return UserBasket.First().myBasket;
        }
    }
}
