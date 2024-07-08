using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    public string Nome { get; set; }
    public int EnderecoId { get; set; }
}
