using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TestApplication.Models;

namespace TestApplication
{
    public class CompanyService
    {
        private readonly CompanyRepository _companyRepository;
        public CompanyService()
        {
            _companyRepository = new CompanyRepository();
        }
        public async Task<List<DeliveryDto>> GetCompanies()
        {
            return await _companyRepository.GetCompanies();
        }
        public Result GetResult(string inn)
        {
            return _companyRepository.GetCompany(inn);
        }
    }
}