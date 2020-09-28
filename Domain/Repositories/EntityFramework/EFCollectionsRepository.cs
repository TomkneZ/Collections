using Collections.Domain.Entities;
using Collections.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections.Domain.Repositories.EntityFramework
{
    public class EFCollectionsRepository : ICollectionsRepository
    {
        private readonly AppDbContext context;
        public EFCollectionsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteCollection(Guid id)
        {
            context.Collections.Remove(new Collection() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<Collection> GetBigestCollections()
        {
            return context.Collections.OrderByDescending(x => x.numberOfItems).Take(3);
        }

        public IQueryable<Collection> GetUsersCollections(string ownerId)
        {
            return context.Collections.Where(c => c.ownerId == ownerId);
        }
        public Collection GetCollectionById(Guid id)
        {
            return context.Collections.FirstOrDefault(x => x.Id == id);
        }

        public Collection GetCollectionById(string id)
        {
            return context.Collections.FirstOrDefault(x => x.Id.ToString() == id);
        }

        public IQueryable<Collection> GetCollections()
        {
            return context.Collections;
        }

        public void SaveCollection(Collection entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
