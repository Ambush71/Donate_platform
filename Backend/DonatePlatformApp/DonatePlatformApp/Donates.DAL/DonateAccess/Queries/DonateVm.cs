using Donates.Domain.Enums;

namespace Donates.DAL.DonateAccess.Queries;

public class GetDonateVm
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Supplier Supplier { get; set; }
    public Needs Needs { get; set; }
    public DateTime CreateDate { get; set; }
    public decimal GoalSum { get; set; }
    public decimal CurrentSum { get; set; }
    public bool IsCompleted { get; set; }
}