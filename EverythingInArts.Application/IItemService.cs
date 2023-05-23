using EverythingInArts.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingInArts.Application
{
    public interface IItemService
    {
        List<Item> GetAllItems();
    }
}
