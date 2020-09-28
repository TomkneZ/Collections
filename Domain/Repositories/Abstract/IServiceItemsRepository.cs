using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collections.Domain.Entities;

namespace Collections.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        IQueryable<ServiceItem> GetLatestItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
