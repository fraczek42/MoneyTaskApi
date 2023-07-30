using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyTaskApi.Model
{
    [Table("expenses_user")]
    public class ExpenseUser
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("amount")]
        public decimal Amount { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("expense_date")]
        public DateTime ExpenseDate { get; set; }

        [Column("is_recurring")]
        public bool IsRecurring { get; set; }

        [Column("recurrence_pattern")]
        public string? RecurrencePattern { get; set; }

        [Column("next_occurrence")]
        public DateTime? NextOccurrence { get; set; }

        [ForeignKey("CategoryId")]
        public CategoryExpense Category { get; set; }
    }

}
