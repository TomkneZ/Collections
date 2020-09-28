using Collections.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections.Models
{
    public class MainPageViewModel
    {
        public IQueryable<Collection> bigestCollections;
        public IQueryable<Item> latestItems;
    }
}
