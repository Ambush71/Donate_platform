using AutoMapper;
using Donate.Application.Mapping;

namespace Donate.Application.Donates.Queries;

public class DonateDetailsVm:IMapWith<Domain.Entities.Donate>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Preposition { get; set; }
    public string Destination { get; set; }
    public decimal GoalSum { get; set; }
    public decimal CurrentSum { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? EditDate { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.Donate, DonateDetailsVm>()
            .ForMember(dVm => dVm.Title,
                o =>
                    o.MapFrom(d => d.Title))
            .ForMember(dVm => dVm.Destination,
                o =>
                    o.MapFrom(d => d.Destination))
            .ForMember(dVm => dVm.Preposition,
                o =>
                    o.MapFrom(d => d.Preposition))
            .ForMember(dVm => dVm.CreationDate,
                o =>
                    o.MapFrom(d => d.CreationDate))
            .ForMember(dVm => dVm.EditDate,
                o =>
                    o.MapFrom(d => d.EditDate))
            .ForMember(dVm => dVm.CurrentSum,
                o =>
                    o.MapFrom(d => d.CurrentSum))
            .ForMember(dVm => dVm.GoalSum,
                o =>
                    o.MapFrom(d => d.GoalSum));

    }
}