using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Expense_Tracker.Models
{
    public class Transactioncs
    {

        [Key]
        public int TransactioId { get; set; }

        // CategoryId
        public int CategoryId { get; set; }
        public Category Category { get; set; } // Here I've refrenced another table by using navigator method
        [Column(TypeName ="nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;


    }
}
