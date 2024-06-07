using BusinessObjects.Context;
using DAO.Interfaces;

namespace DAO;

public class GoldPriceDao : Singleton<GoldPriceDao>
{
    private readonly JssatsContext _context;
    public GoldPriceDao()
    {
        _context = new JssatsContext();
    }
}