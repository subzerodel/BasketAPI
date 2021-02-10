using StackExchange.Redis;

namespace BasketAPI.Data.Interfaces
{
    public interface IBasketCartContext
    {
        IDatabase Redis { get; }
    }
}