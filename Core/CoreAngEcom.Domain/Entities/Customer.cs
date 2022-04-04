using CoreAngEcom.Domain.Entities.Common;

namespace CoreAngEcom.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

