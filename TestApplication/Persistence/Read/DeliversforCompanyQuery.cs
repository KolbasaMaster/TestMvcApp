using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApplication.Models;

namespace TestApplication.Persistence.Read
{
    public class DeliversforCompanyQuery
    {
        private readonly TestAppContext _dbContext;
        public DeliversforCompanyQuery() 
        {
           _dbContext = new TestAppContext();
        }

        public IEnumerable<Models.Result> Execute(string inn)
        {
            return _dbContext.Company.Where(x => x.INN.Contains(inn)).Join(_dbContext.Delivery, x => x.INN, d => d.INN,
                (x, d) => new Models.Result()
                {
                    Inn = x.INN,
                    Name = x.Name,
                    Sum = d.Sum,
                    RubSum = d.Сurrency
                });
        }

    }
}