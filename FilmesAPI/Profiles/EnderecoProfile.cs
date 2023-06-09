using AutoMapper;
using FilmesAPI.Data.Dtos;

namespace FilmesAPI.Models.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, CreateEnderecoDto>();
            CreateMap<CreateEnderecoDto, Endereco>();

        }
    }
}
