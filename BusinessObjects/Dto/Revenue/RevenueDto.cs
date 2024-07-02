using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Dto.Revenue
{
    public class RevenueDto
    {
        public decimal TotalRevenue { get; set; }

        public static implicit operator decimal(RevenueDto v)
        {
            throw new NotImplementedException();
        }
    }
}
