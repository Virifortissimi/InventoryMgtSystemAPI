using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryMgtSystemAPI.Models
{
    public class InventoryModel
    {
        [Key]
        public int InventoryId { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public DateTime DatePurchased {get; set; }
        [Required]
        public int AmountPerItem { get; set; }
        [Required]
        public int StockQty { get; set; }
        [Required]
        public int TotalAmount => (int) (StockQty * AmountPerItem);
    }
}