using AutoMapper;
using FilmesAPI.Data.Dtos;

namespace FilmesAPI.Models.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>().ForMember(cinemaDto => cinemaDto.Endereco,
                                                           opt => opt.MapFrom(cinema => cinema.Endereco));
        CreateMap<UpdateCinemaDto, Cinema>();
    }
}
