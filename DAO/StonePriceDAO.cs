using BusinessObjects.Context;
using DAO.Interfaces;

namespace DAO;

public class StonePriceDAO : Singleton<StonePriceDAO>
{
    private readonly JssatsContext _context;
    public StonePriceDAO()
    {
        _context = new JssatsContext();
    }
}