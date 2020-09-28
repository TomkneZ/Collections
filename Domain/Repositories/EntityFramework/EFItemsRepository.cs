using Collections.Domain.Entities;
using Collections.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections.Domain.Repositories.EntityFramework
{
    public class EFItemsRepository : IItemsRepository
    {
        private readonly AppDbContext context;
        public EFItemsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteItem(Guid id)
        {
            context.Items.Remove(new Item() { Id = id });
            context.SaveChanges();
        }

        public Item GetItemById(Guid id)
        {
            return context.Items.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Item> GetItems()
        {
            return context.Items;
        }

        public IQueryable<Item> GetLatestItems()
        {
            return context.Items.OrderByDescending(x => x.DateAdded).Take(5);
        }
    
        public IQueryable<Item> GetItemsByCollectionId(string Id)
        {
            return context.Items.Where(i => i.CollectionId == Id);
        }

        public void SaveItem(Item entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
