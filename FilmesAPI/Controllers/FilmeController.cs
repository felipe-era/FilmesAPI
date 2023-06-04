using FilmesAPI.Data;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    #region == Atributos ==

    // \/ inicialmente utilizada para criar o bd
    //private static List<Filme> filmes = new List<Filme>();
    //private static int id = 0;

    private FilmeContext _context;

    public FilmeController(FilmeContext context)
    {
        _context = context;
    }

    #endregion

    [HttpPost] //post
    public IActionResult AdicionaFilme([FromBody] Filme filme) //[FromBody] é o que vem no corpo da requisição
    {
        //por validações por region..
        //if ((!string.IsNullOrEmpty(filme.Titulo) && (!string.IsNullOrEmpty(filme.Genero)) && filme.Duracao >= 70))
        //{ } Não se utiliza validações aqui.. usa a data annotations la na classe filme no caso
        filme.Id = id++;
        filmes.Add(filme);

        //Padrão rest como é?
        //R: deve-se retornar o objeto ao usuário (Retornar as informações que foram recém cadastradas (inseridas)
        //
        return CreatedAtAction(nameof(ConsultaFilmesPorId), //chama o método get para apresentar ao usuario
                               new { id = filme.Id }, //parametro do método acima
                               filme);
    }

    //[HttpGet] //consulta todos os filmes
    //public IEnumerable<Filme> ConsultaFilmes()
    //{
    //    return filmes;
    //}

    //[HttpGet("{id}")] //quando tiver parâmetros é necessario adicionar ao get
    //public Filme? ConsultaFilmesPorId(int id)
    //{
    //    return filmes.FirstOrDefault(filme => filme.Id == id);
    //    //o endereço informado pelo usuário retornar o endereço informado pelo usuário.
    //    //caso não tenha traz nulo
    //    //Ex: para trazer o filme id 1 usar o get no Postman/insomnia
    //    //https://localhost:7105/filme/1
    //}

    [HttpGet] //consulta filmes por intervalo skip and take 
    //https://localhost:7105/filme?skip=5&take=2 pula 5 e pega os 2 primeiros \/ quando não informado deixa o valor padrão como 0 ou 2
    public IEnumerable<Filme> ConsultaFilmesIntervalo([FromQuery] int skip = 0, [FromQuery] int take = 2)
    {
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")] //
    public IActionResult ConsultaFilmesPorId(int id)
    {
        var objfilme = filmes.FirstOrDefault(filme => filme.Id == id);

        if (objfilme == null) return NotFound();

        return Ok(objfilme);
    }



}
