using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs
{
    public class CreateFilmeDTO
    {

        [Required(ErrorMessage = "O Titulo do filme é obrigatório")]
        [StringLength(100, ErrorMessage = "O tamanho do titulo não pode exceder 100caracteres")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "O Genero do filme é obrigatório")]
        [StringLength(100, ErrorMessage = "O tamanho do genero não pode exceder 100caracteres")]
        public string? Genero { get; set; }
        [Required]
        [Range(60, 600, ErrorMessage = "A duração deve ser entre 60 e 600 minutos")] 
        public int Duracao { get; set; }
    }
}
