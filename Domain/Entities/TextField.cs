using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Collections.Domain.Entities
{
    public class TextField : EntityBase
    {   

        [Required]
        public Guid Id { get; set; }      

        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        public virtual string Value { get; set; }

        public virtual string Type { get; set; }

        /*public enum psblThemes
        {
            [Display(Name = "Alcohol")] Alcohol,
            [Display(Name = "Books")] Books,
            [Display(Name = "Photos")] Photos,
            [Display(Name = "Films")] Films
        }
        [Display(Name = "Theme")]
        public psblThemes Theme { get; set; }

        [Display(Name = "Image")]
        public virtual string TitleImagePath { get; set; }*/
     
        [Required]
        public string CodeWord { get; set; }      
      
    }
}
