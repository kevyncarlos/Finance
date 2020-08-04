using Finance.Data;
using Finance.Data.Entities;
using Microsoft.Extensions.Logging;

namespace Finance.Access.Repositories
{
    public class PaymentRepository : Repository<Payment>
    {
        public PaymentRepository(FinanceContext context, ILogger<Repository<Payment>> logger) : base(context, logger)
        {
        }
    }
}
