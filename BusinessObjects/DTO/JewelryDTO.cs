using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DTO
{
    public class JewelryDTO
    {
        public int? JewelryTypeId { get; set; }

        public int? WarrantyId { get; set; }

        public string? Name { get; set; }

        public string? Barcode { get; set; }

        public double? BasePrice { get; set; }

        public double? Weight { get; set; }

        public double? LaborCost { get; set; }

        public double? StoneCost { get; set; }
    }
}
