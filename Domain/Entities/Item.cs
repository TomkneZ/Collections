using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Collections.Domain.Entities
{
    public class Item : EntityBase
    {
        [Required]
        public Guid Id { get; set; }

        public string CollectionId { get; set; }

        public Item() => DateAdded = DateTime.UtcNow;

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Tag")]
        public string Tag { get; set; }
        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

        public int Num1Value { get; set; }

        public int Num2Value { get; set; }

        public int Num3Value { get; set; }

        public string Input1Value { get; set; }

        public string Input2Value { get; set; }

        public string Input3Value { get; set; }

        public string Textarea1Value { get; set; }

        public string Textarea2Value { get; set; }

        public string Textarea3Value { get; set; }

        public string Date1Value { get; set; }

        public string Date2Value { get; set; }

        public string Date3Value { get; set; }

        public bool Checkbox1Value { get; set; }

        public bool Checkbox2Value { get; set; }

        public bool Checkbox3Value { get; set; }

        public int itemFields { get; set; } //битовая маска для полей*/
    }
}
