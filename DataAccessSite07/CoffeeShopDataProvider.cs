using DataAccessSite07.Model;
using System.Collections.Generic;

namespace DataAccessSite07
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop
            {
                Location = "Frankfurt",
                BeansInStockInKg = 842,
            };
            yield return new CoffeeShop
            {
                Location = "Freiburg",
                BeansInStockInKg = 84,
            };
            yield return new CoffeeShop
            {
                Location = "Munich",
                BeansInStockInKg = 32,
            };
        }
    }
}
