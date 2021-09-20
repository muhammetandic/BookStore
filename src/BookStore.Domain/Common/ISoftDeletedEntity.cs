namespace BookStore.Domain.Common
{
    public interface ISoftDeletedEntity
    {
        public bool IsDeleted { get; set; }
    }
}
