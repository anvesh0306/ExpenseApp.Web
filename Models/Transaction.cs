namespace ExpenseApp.Web.Models;

public class Transaction
{
    public int Id { get; set; }

    public int Amount { get; set; }

    public string Description { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;
}