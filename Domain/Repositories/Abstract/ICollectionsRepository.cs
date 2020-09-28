using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collections.Domain.Entities;

namespace Collections.Domain.Repositories.Abstract
{
    public interface ICollectionsRepository
    {
        IQueryable<Collection> GetCollections();
        IQueryable<Collection> GetUsersCollections(string ownerId);
        IQueryable<Collection> GetBigestCollections();
        Collection GetCollectionById(Guid id);
        Collection GetCollectionById(string id);
        void SaveCollection(Collection entity);
        void DeleteCollection(Guid id);
    }
}
