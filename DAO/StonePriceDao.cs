using BusinessObjects.Context;
using DAO.Interfaces;

namespace DAO;

public class StonePriceDao : Singleton<StonePriceDao>
{
    private readonly JssatsContext _context;
    public StonePriceDao()
    {
        _context = new JssatsContext();
    }
}