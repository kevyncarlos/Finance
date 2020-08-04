using Finance.Data;
using Finance.Data.Entities;
using Microsoft.Extensions.Logging;

namespace Finance.Access.Repositories
{
    public class MoneyRepository : Repository<Money>
    {
        public MoneyRepository(FinanceContext context, ILogger<Repository<Money>> logger) : base(context, logger)
        {
        }
    }
}
