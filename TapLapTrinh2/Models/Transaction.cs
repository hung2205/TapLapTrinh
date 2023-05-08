using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TapLapTrinh.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int Amount { get; set; }
        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [NotMapped]
        public string? CategogyTitleIcon
        {
            get
            {
                return Category == null? "": Category.Icon + " " +Category.Title;
            }
        }
        public string? FormattedAmount
        {
            get
            {
                return ((Category == null || Category.Type == "Expense") ? "- " : "+ " ) + Amount.ToString("c0");
            }
        }

    }
}
