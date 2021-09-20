using BookStore.Domain.Common;
using System.Collections.Generic;

namespace BookStore.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int? ParenCategoryId { get; set; }
        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<Category> SubCategories { get; set; }

    }
}
