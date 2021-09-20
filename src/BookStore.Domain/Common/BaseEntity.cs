using System;

namespace BookStore.Domain.Common
{
    public class BaseEntity : IEntity, IAuditableEntity, ISoftDeletedEntity
    {
        public int Id { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
