namespace finance_tracker_client.Models
{
    public class TransactionSummary
    {
        public string incomes { get; set; }
        public string expenses { get; set; }
        public string savings { get; set; }

        public string savingsPercent { get; set; }
    }
}
