using BusinessObjects.Models;
using DAO.Context;
using DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class JewelryTypeDAO : Singleton<JewelryTypeDAO>
    {
        private readonly JssatsV2Context _context;
        public JewelryTypeDAO()
        {
            _context = new JssatsV2Context();
        }
        public async Task<JewelryType?> GetJewelryTypeById(int? id)
        {
            return await _context.JewelryTypes.FindAsync(id);
        }
    }
}
