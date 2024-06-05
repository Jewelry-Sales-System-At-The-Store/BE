using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.DTO
{
    public class JewelryDTO
    {
        [Range(1, int.MaxValue, ErrorMessage = "JewelryTypeId must be a positive number.")]
        public int? JewelryTypeId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Barcode is required.")]
        [StringLength(50, ErrorMessage = "Barcode length can't be more than 50.")]
        public string? Barcode { get; set; }
        
        [Range(0.0, double.MaxValue, ErrorMessage = "LaborCost must be a non-negative number.")]
        public double? LaborCost { get; set; }

    }
}
