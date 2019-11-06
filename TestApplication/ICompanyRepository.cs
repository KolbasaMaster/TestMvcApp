using System.Collections.Generic;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication
{
    public interface ICompanyRepository
    {
         Task<List<DeliveryDto>> GetCompanies();
         Task <DeliveryDto> GetCompany(int id);
      //   Task<DeliveryDto> AddCompany(DeliveryDto company);

    }
}