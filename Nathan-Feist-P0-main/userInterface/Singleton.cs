using Models;

namespace userInterface
{
    public class Singleton
    {
        public static Users user = new Users();
        public static StoreLocations locations = new StoreLocations();
        public static LineItems lineItems = new LineItems();
        public static Orders orders = new Orders();
        public static Products product = new Products();
    }
}