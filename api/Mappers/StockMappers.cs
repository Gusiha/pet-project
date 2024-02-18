using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this StockModel stockModel)
        {
            return new StockDto()
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Industry = stockModel.Industry,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                MarketCap = stockModel.MarketCap,
                Comments = stockModel.Comments.Select(c => c.ToCommentDto()).ToList()
            };
        }

        public static StockModel ToStockFromCreateDTO(this CreateStockRequestDto stockDto)
        {
            return new StockModel()
            {
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                LastDiv = stockDto.LastDiv,
                Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap
            };
        }

    }
}