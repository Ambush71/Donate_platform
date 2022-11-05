using AutoMapper;

namespace Donate.Application.Donates.Queries.GetDonateList;

public class DonateLookupDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.Donate, DonateLookupDto>()
            .ForMember(dDto => dDto.Id,
                opt =>
                    opt.MapFrom(d => d.Id))
            .ForMember(dDto => dDto.Title,
                opt =>
                    opt.MapFrom(d => d.Title));
    }
}