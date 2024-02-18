using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Stock;
using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<StockModel>> GetAllAsync(QueryObject query);
        Task<StockModel?> GetByIdAsync(int id);
        Task<StockModel?> GetBySymbolAsync(string symbol);
        Task<StockModel> CreateAsync(StockModel stockModel);
        Task<StockModel?> UpdateAsync(int id, UpdateStockRequestDto stockRequestDto);
        Task<StockModel?> DeleteAsync(int id);
        Task<bool> StockExists(int id);
    }
}