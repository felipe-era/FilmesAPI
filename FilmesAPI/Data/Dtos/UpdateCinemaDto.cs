using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O NOME deve estar preenchido..")]
    public string Nome { get; set; }
}
