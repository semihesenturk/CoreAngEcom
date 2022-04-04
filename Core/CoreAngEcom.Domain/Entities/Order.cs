using CoreAngEcom.Domain.Entities.Common;

namespace CoreAngEcom.Domain.Entities
{
    public class Order :BaseEntity
	{
        public int CustomerId { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

