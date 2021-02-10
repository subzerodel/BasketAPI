using BasketAPI.Data.Interfaces;
using StackExchange.Redis;

namespace BasketAPI.Data
{
    public class BasketCartContext : IBasketCartContext
    {
        private readonly ConnectionMultiplexer _connection;

        public BasketCartContext(ConnectionMultiplexer connection)
        {
            _connection = connection;
            Redis = _connection.GetDatabase();
        }

        public IDatabase Redis { get; }
    }
}