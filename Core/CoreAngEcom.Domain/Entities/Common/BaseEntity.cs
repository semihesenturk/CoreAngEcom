namespace CoreAngEcom.Domain.Entities.Common
{
    public class BaseEntity
	{
        public Guid Id { get; set; }
        public DateTime CretedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}

