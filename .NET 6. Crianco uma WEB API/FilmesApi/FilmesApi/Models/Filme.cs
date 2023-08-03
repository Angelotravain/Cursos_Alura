using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Modesls;

public class Filme
{
    // usar Data Annotation para fazer as devidas validações validações para API podem ser feitas por aqui, deixa o código melhor e mais bem estruturado
    [Key]
    [Required]
    public int Id { get; set; }

    // para criar um model Add-Migration CriandoTabelaDeFilme
    // antes de fazer deve instalar Install-Package Microsoft.EntityFrameworkCore.Tools

    // para dar um update no banco e gerar a tabela com o banco e os dados executar 

    // Update-Database
    [Required(ErrorMessage = "O Titulo do filme é obrigatório")]
    [MaxLength(100, ErrorMessage = "O tamanho do titulo não pode exceder 100caracteres")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "O Genero do filme é obrigatório")]
    [MaxLength(100, ErrorMessage ="O tamanho do genero não pode exceder 100caracteres")]
    public string? Genero { get; set; }
    [Required]
    [Range(60,600, ErrorMessage = "A duração deve ser entre 60 e 600 minutos")] // não é interesante que o nosso model fique tão exposto para o cliente
    public int Duracao { get; set; }
}
