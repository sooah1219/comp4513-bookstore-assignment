namespace Bookstore.Models;

public class OrderItem
{
    public int Id { get; set; }

    public int BookId { get; set; }   
    public Book Book { get; set; } = default!;

    public int Quantity { get; set; }

    public decimal GetTotal() => Book.Price * Quantity;
}