using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<List<StockModel>> GetUserPortfolio(AppUser user);
        Task<PortfolioModel> CreateAsync(PortfolioModel portfolio);
        Task<PortfolioModel> DeletePortfolio(AppUser appUser, string symbol);
    }
}