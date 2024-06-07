using BusinessObjects.Context;
using DAO.Interfaces;

namespace DAO;

public class BillPromotionDAO : Singleton<BillPromotionDAO>
{
    private readonly JssatsContext _context;
    public BillPromotionDAO()
    {
        _context = new JssatsContext();
    }
}