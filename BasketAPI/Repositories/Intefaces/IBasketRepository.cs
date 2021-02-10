using System.Threading.Tasks;
using BasketAPI.Entities;

namespace BasketAPI.Repositories.Interfaces
{
    public interface IBasketRepository
    {
        Task<BasketCart> GetBasketCart(string username);
        Task<BasketCart> UpdateBasketCart(BasketCart basketCart);
        Task<bool> DeleteBasketCart(string username);
    }
}