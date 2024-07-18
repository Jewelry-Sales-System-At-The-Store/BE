using BusinessObjects.Dto.BuyBack;

namespace Services.Interface
{
    public interface IPurchaseService
    {
        Task<string> ProcessBuybackById(string jewelryId);
        Task<string> ProcessBuybackByName(BuybackByNameRequest request);
        Task<string> CountProcessBuybackByName(CountBuybackByNameRequest request);
        Task<string> CountProcessBuybackById(string jewelryId);
    }
}
