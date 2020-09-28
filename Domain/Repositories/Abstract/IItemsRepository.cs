using Collections.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections.Domain.Repositories.Abstract
{
    public interface IItemsRepository
    {
        IQueryable<Item> GetItems();
        IQueryable<Item> GetLatestItems();
        IQueryable<Item> GetItemsByCollectionId(string Id);        
        Item GetItemById(Guid id);
        void SaveItem(Item entity);
        void DeleteItem(Guid id);
    }
}
