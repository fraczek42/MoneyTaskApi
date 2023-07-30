using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyTaskApi.Model
{
    [Table("categories_expenses")]
    public class CategoryExpense
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("is_recurring")]
        public bool IsRecurring { get; set; }
    }

}
