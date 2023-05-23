using EverythingInArts.Domain;

namespace EverythingInArts.Application
{
    public interface IItemRepository
    {
        List<Item> GetAllItems();
    }
}