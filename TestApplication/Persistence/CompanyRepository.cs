using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.UI.WebControls;
using TestApplication.Models;
using TestApplication.Persistence.Read;

namespace TestApplication
{
    public class CompanyRepository
    {
        private readonly List<DeliveryDto> _companies;
        private readonly DeliversforCompanyQuery _query;

        public CompanyRepository()
        {
            _companies = new List<DeliveryDto>() ;
            _query = new DeliversforCompanyQuery();
        }
        public async Task<List<DeliveryDto>> GetCompanies()
        {
            return await Task.Run(() => _companies);
        }
        
        public Result GetCompany(string id)
        {
            Result result = new Result();
            var deliverys = _query.Execute(id);
            foreach (var delivery in deliverys)
            {
                result.Inn = id;
                result.Sum += delivery.Sum;
                result.RumSum += delivery.RubSum;
            }

            result.Deliverys = deliverys.Count();
            return result;
        }
    }
}