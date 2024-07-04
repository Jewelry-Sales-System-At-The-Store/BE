using BusinessObjects.Dto;
using BusinessObjects.Dto.BuyBack;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IPurchaseService
    {
        Task<string> ProcessBuybackById(string jewelryId);
        Task<string> ProcessBuybackByName(BuybackByNameRequest request);
    }
}
