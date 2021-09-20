using BookStore.Domain.Common;

namespace BookStore.Domain.Entities
{
    public class Publisher : BaseEntity
    {
        public string Name { get; set; }
        public string About { get; set; }
    }
}
