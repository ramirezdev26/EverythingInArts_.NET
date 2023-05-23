using EverythingInArts.Application;
using EverythingInArts.Domain;

namespace EverythingInArts.Infraestructure
{
    public class ItemRepository : IItemRepository
    {

        public static List<Item> items = new List<Item>()
        {
            new Item{Id=1, Name="Item", Category="cat", Description="des", Images={ "asd", "asd" }, Price=12, Stock=2 },
            new Item{Id=2, Name="Item", Category="cat", Description="des", Images={ "asd", "asd" }, Price=12, Stock=2 }
        };

        public List<Item> GetAllItems()
        {
            return items;
        }
    }
}