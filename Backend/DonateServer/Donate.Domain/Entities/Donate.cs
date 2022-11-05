namespace Donate.Domain.Entities;

public class Donate
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Preposition { get; set; }
    public string Destination { get; set; }
    public decimal GoalSum { get; set; }
    public decimal CurrentSum { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? EditDate { get; set; }

}