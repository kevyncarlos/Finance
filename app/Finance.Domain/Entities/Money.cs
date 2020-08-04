using System.Collections;
using System.Collections.Generic;
using Finance.Data.Enums;

namespace Finance.Data.Entities
{
    public class Money : Entity
    {
        public string Description { get; set; }
        public string Observation { get; set; }
        public decimal Value { get; set; }
        public string Code { get; set; }
        public TypeAction Action { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
