using System.ComponentModel.DataAnnotations;

namespace finance_tracker_client.Models
{
    public class TransactionDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        //[Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public string Amount { get; set; }

        [Required]
        [EnumDataType(typeof(TransactionType), ErrorMessage = "Type must be either 'Income' or 'Expense'.")]
        public TransactionType Type { get; set; }
    }
}
