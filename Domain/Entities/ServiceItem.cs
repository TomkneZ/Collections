using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Collections.Domain.Entities
{
    public class ServiceItem : EntityBase
    {      
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Name")]
        public virtual string Title { get; set; }

        [Display(Name = "Short description")]
        public virtual string shortDescription { get; set; }

        public enum psblThemes
        {
            [Display(Name = "Alcohol")] Alcohol,
            [Display(Name = "Books")] Books,
            [Display(Name = "Photos")] Photos,
            [Display(Name = "Films")] Films
        }
        [Display(Name = "Theme")]
        public psblThemes Theme { get; set; }

        [Display(Name = "Image")]
        public virtual string TitleImagePath { get; set; }

        public ushort itemFields { get; set; }

        public string ownerId { get; set; }

        public int numberOfItems { get; set; } = 0;
    }
}
