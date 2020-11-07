using System;
using System.ComponentModel.DataAnnotations;

namespace SPENGO.Data.Models
{
    public class WalletModel
    {
        [Key]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
    }
}
