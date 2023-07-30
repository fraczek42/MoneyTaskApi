using Microsoft.EntityFrameworkCore;
using MoneyTaskApi.Model;

namespace MoneyTaskApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<ExpenseUser> ExpensesUser { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CategoryExpense> CategoriesExpenses { get; set; }

    }

}
