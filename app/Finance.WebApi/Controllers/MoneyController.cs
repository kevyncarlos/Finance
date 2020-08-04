using Finance.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Finance.Access.Repositories;

namespace Finance.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoneyController : ControllerBase
    {
        private readonly ILogger<MoneyController> _logger;
        private readonly MoneyRepository _moneyRepository;

        public MoneyController(ILogger<MoneyController> logger, MoneyRepository moneyRepository)
        {
            _logger = logger;
            _moneyRepository = moneyRepository;
        }

        [HttpPost]
        public Money Add([FromBody]Money money)
        {
            return _moneyRepository.Add(money);
        }

        [HttpGet]
        public IEnumerable<Money> GetAll()
        {
            return _moneyRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Money Get(int id)
        {
            return _moneyRepository.GetById(id);
        }
    }
}
