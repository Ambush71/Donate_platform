using AutoMapper;
using Donate.Application.Common.Mapping;
using Donate.Domain.Entities.Enums;

namespace Donate.Application.Donates.Queries.GetDonate;

public class DonateVm : IMapWith<Domain.Entities.Donate>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Needs Needs { get; set; }
    public Supplier Supplier { get; set; }
    public decimal GoalSum { get; set; }
    public decimal CurrentSum { get; set; }
    public DateTime CreateDate { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.Donate, DonateVm>()
            .ForMember(dVm => dVm.Title,
                o =>
                    o.MapFrom(d => d.Title))
            .ForMember(dVm => dVm.Needs,
                o =>
                    o.MapFrom(d => d.Needs))
            .ForMember(dVm => dVm.Supplier,
                o =>
                    o.MapFrom(d => d.Supplier))
            .ForMember(dVm => dVm.CreateDate,
                o =>
                    o.MapFrom(d => d.CreateDate))
            .ForMember(dVm => dVm.CurrentSum,
                o =>
                    o.MapFrom(d => d.CurrentSum))
            .ForMember(dVm => dVm.GoalSum,
                o =>
                    o.MapFrom(d => d.GoalSum));
    }
}