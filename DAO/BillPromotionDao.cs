using BusinessObjects.Context;
using DAO.Interfaces;

namespace DAO;

public class BillPromotionDao : Singleton<BillPromotionDao>
{
    private readonly JssatsContext _context;
    public BillPromotionDao()
    {
        _context = new JssatsContext();
    }
}