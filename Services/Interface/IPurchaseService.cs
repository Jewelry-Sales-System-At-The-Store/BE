using BusinessObjects.Dto.BuyBack;

namespace Services.Interface
{
    public interface IPurchaseService
    {
        Task<string> ProcessBuybackById(string jewelryId);
        Task<string> ProcessBuybackByName(BuybackByNameRequest request);
    }
}
