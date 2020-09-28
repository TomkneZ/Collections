using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Collections.Domain.Entities
{
    public class Collection : EntityBase
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
            [Display(Name = "Movies")] Movies,
            [Display(Name ="TV shows")] TVShows,
            [Display(Name ="Comics")] Comics,
            [Display(Name ="Games")] Games
        }
        [Display(Name = "Theme")]
        public psblThemes Theme { get; set; }

        [Display(Name = "Image")]
        public virtual string TitleImagePath { get; set; }

        public int itemFields { get; set; }
        public string Num1Name { get; set; }

        public string Num2Name { get; set; }

        public string Num3Name { get; set; }

        public string Input1Name { get; set; }

        public string Input2Name { get; set; }

        public string Input3Name { get; set; }

        public string Textarea1Name { get; set; }

        public string Textarea2Name { get; set; }

        public string Textarea3Name { get; set; }

        public string Date1Name { get; set; }

        public string Date2Name { get; set; }

        public string Date3Name { get; set; }

        public string Checkbox1Name { get; set; }

        public string Checkbox2Name { get; set; }

        public string Checkbox3Name { get; set; }

        public string ownerId { get; set; }

        public int numberOfItems { get; set; } = 0;
    }
}
