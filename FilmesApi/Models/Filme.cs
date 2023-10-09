using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;
public class Filme
{
    public int Id { get; internal set; }

    [Required (ErrorMessage = "O titulo é obrigatório")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "O Genero é obrigatório")]
    public string? Genero { get; set; }
    [Range(60, 2000, ErrorMessage = "o tamanho da duração não pode exceder 2000")]
    [Required(ErrorMessage = "o tamanho da duração não pode exceder 2000")]
    public int? Duracao { get; set; }

}
