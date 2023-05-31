using BenMabelProject.Entity.DtoS.Finanss;
using BenMabelProject.Entity.DtoS.Orders;

namespace BenMabelProject.Services.Services.Abstractions
{
    public interface IFinanceService
    {
        Task<FinanceDayDto> FinanceDay();
        Task<FinanceDayDto> FinanceWeek();
        Task<FinanceDayDto> FinanceMounth();
        
    }
}
