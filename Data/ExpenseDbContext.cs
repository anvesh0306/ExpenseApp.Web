using ExpenseApp.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseApp.Web.Data;

public class ExpenseDbContext : DbContext
{
    public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options)
        : base(options)
    {
    }

    public DbSet<Transaction> Transactions { get; set; }
}