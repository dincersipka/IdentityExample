namespace IdentityExample.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string? UpdatedBy { get; set; }
        public DateTime UpdateDate { get; set; }

        public string? DeletedBy { get; set; }
        public string? DeleteDate { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
