using System;
namespace Domain
{
    public class Expense
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}