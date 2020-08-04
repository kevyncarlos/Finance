using Finance.Data.Enums;

namespace Finance.Data.Entities
{
    public class Payment : Entity
    {
        public int MoneyId { get; set; }
        public decimal Value { get; set; }
        public TypeStatus Status { get; set; }

        public Money Money { get; set; }
    }
}
