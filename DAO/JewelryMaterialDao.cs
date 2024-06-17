using BusinessObjects.Context;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO;

public class JewelryMaterialDao
{
    private readonly JssatsContext _context;
    public JewelryMaterialDao()
    {
        _context = new JssatsContext();
    }
    public async Task<IEnumerable<JewelryMaterial>?> GetJewelryMaterials()
    {
        return await _context.JewelryMaterials.ToListAsync();
    }
    public async Task<JewelryMaterial?> GetJewelryMaterialByJewelry(string jewelryId)
    {
        return await _context.JewelryMaterials.FirstOrDefaultAsync(jm => jm.JewelryId == jewelryId);
    }
}