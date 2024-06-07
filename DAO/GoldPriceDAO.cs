using BusinessObjects.Context;
using DAO.Interfaces;

namespace DAO;

public class GoldPriceDAO : Singleton<GoldPriceDAO>
{
    private readonly JssatsContext _context;
    public GoldPriceDAO()
    {
        _context = new JssatsContext();
    }
}