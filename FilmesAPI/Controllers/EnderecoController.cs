using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Controllers;

public class EnderecoController :Profile
{
    public EnderecoController()
    {
        CreateMap<CreateEnderecoDto, Endereco>();
        CreateMap<Endereco, ReadEnderecoDto>();
        CreateMap<UpdateEnderecoDto, Endereco>();
    }
}
