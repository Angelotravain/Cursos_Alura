using FilmesApi.Modesls;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> Filmes = new();

    [HttpPost] // tipo de requisição Http que será usada, no caso a requisição usada pela API para o post que usa  método abaixo, independente do nome do método com esse Http ele faz a validação 
    public void AdicionaFilme([FromBody] Filme filme)
    { 
        // Aqui é onde realizamos os devidos códigos para serem consumidos pelos ambientes externos da API, 
        Filmes.Add(filme);
        Console.WriteLine(filme.Duracao);
        Console.WriteLine(filme.Titulo);

        // Para realizar a chamada da API, como utilizado no postman usamos o caminho da API e em seguida colocamos o nome da controller que queremos chamar 
        //No caso aqui /filme não importando entre maiusculo e minusculo, o tipo de dados que trafega entre as API's são arquivos de Json
    }
}
