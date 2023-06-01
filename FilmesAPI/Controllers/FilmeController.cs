using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;

    [HttpPost] //post
    public void AdicionaFilme([FromBody]Filme filme) //[FromBody] é o que vem no corpo da requisição
    {
        //por validações por region..
        //if ((!string.IsNullOrEmpty(filme.Titulo) && (!string.IsNullOrEmpty(filme.Genero)) && filme.Duracao >= 70))
        //{ } Não se utiliza validações aqui.. usa a data annotations la na classe filme no caso
        filme.Id = id++;
        filmes.Add(filme); 
        Console.WriteLine("Após o ADD e validações");
        Console.WriteLine(filme.Titulo); 
        Console.WriteLine(filme.Genero);
        Console.WriteLine(filme.Duracao);
    }

    [HttpGet] //get
    public IEnumerable<Filme> ConsultaFilmes()
    {
        return filmes;
    }

    [HttpGet("{id}")] //quando tiver parâmetros é necessario adicionar ao get
    public Filme? ConsultaFilmesPorId(int id)
    {
        return filmes.FirstOrDefault(filme => filme.Id == id);
        //o endereço informado pelo usuário retornar o endereço informado pelo usuário.
        //caso não tenha traz nulo
        //Ex: para trazer o filme id 1 usar o get no Postman/insomnia
        //https://localhost:7105/filme/1
    }

     



}
 