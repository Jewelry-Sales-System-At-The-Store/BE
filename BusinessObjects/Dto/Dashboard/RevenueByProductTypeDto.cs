using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Dto.Revenue
{
    public class RevenueByProductTypeDto
    {
        public string JewelryTypeId { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
