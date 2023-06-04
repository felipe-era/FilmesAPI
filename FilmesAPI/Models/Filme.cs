using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O TÍTULO deve estar preenchido..")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O GÊNERO deve estar preenchido")]
    [MaxLength(50, ErrorMessage = "Máximo de 50 Caracteres para o GENÊRO..")]
    public string Genero { get; set; }
    
    [Required(ErrorMessage = "A DURAÇÃO deve estar preenchido")]
    [Range(70, 600, ErrorMessage = "A duração deve estar entre 70 e 600..")]
    public int Duracao { get; set; }

    //[StringLength] = o maxLength????
    //[Required]
    //public string Diretor { get; set; }

}
