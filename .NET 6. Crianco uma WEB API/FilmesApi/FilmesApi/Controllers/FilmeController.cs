using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.DTOs;
using FilmesApi.Modesls;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    //private static List<Filme> Filmes = new();
    //private static int id = 0;

    /// <summary>
    /// Adiciona um filme ao banco de dados
    /// </summary>
    /// <param name="filmeDto">Objeto com os campos necessários para criação de um filme</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>
    [HttpPost] // tipo de requisição Http que será usada, no caso a requisição usada pela API para o post que usa  método abaixo, independente do nome do método com esse Http ele faz a validação 
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AdicionaFilme([FromBody] CreateFilmeDTO filmeDto)
    {
        Filme filme = _mapper.Map<Filme>(filmeDto);
        // para criação de um mapeamento de filme 
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        // Aqui é onde realizamos os devidos códigos para serem consumidos pelos ambientes externos da API, 
        //filme.Id = id++;
        //Filmes.Add(filme);

        // aqui é onde fazemos um retorno para nossa aplicação pela API, no caso ela vai estar retornando uma ação com o método Get estánciado abaixo
        return CreatedAtAction(nameof(RecuperaFilmePorId), new { id = filme.Id },
            filme); // esse cara retorna um location para acessar a aplicação, no caso ele retorna um valor (link) que pode ser consumido para uso da API


        // Para realizar a chamada da API, como utilizado no postman usamos o caminho da API e em seguida colocamos o nome da controller que queremos chamar 

        //No caso aqui /filme não importando entre maiusculo e minusculo, o tipo de dados que trafega entre as API's são arquivos de Json
    }
    // agora posso fazer um novo método para realizar a leitura dos dados 
    [HttpGet]
    public IEnumerable<ReadFilmeDTO> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        // Método vai ser responsável por fazer a leitura dos métodos post insere get pega e lê

        // return _context.Filmes.Skip(skip).Take(take); // .skip pula uma quantidade determinada e .take quantos eu quero pegar (dados no caso)

        return _mapper.Map<List<ReadFilmeDTO>>(_context.Filmes.Skip(skip).Take(take));
        //para recuperar o link passado é https://localhost:7190/Filme?Skip=2&Take=10, caso o usuário não passe nada, precisamos assumir valores padrão para Skip e Take
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaFilmePorId(int id)
    {
        // esse método é o mesmo get do de cima, porém agora usamos um bind para passar o id e buscar pelo id desejado para recuperar pelo id passa o prefixo /id no caso /1
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound(); // aqui são as validações de retorno da API, caso não encontre os dados necessários ele retorna um Not Found 
        var filmeDto = _mapper.Map<ReadFilmeDTO>(filme);
        return Ok(filmeDto);// caso encontre ele retorna Um OK com os dados a serem retornados 
    }
    // para carregar uma grande quantidade de dados, ou carregamos de 1 em 1 ou tudo, isso pode ser muito lento ou carregar e usar muita memória, mas por isso temas a paginação, para ,net podemos usar o skip ou o take

    // para retornar dados mais precisos recisamos verificar e validar informações para erros 

    [HttpPut("{id}")]
    public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDTO filmeDto)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();
        return NoContent();

        //        {       modelo usado no put
        //            "Titulo": "Os simpsons",
        //    "Genero": "Fição",
        //    "Duracao": 200
        //}

        // link usado no put https://localhost:7190/Filme/2

        // método para fazer a atualização do método, o mesmo atualiza os dados, o mesmo faz a atualização de todos os dados que são enviados 
    }
    [HttpPatch]
    public IActionResult AtualizaFilmeParcial(int id, JsonPatchDocument<UpdateFilmeDTO> patch)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();

        var filmeParaAtualizar = _mapper.Map<UpdateFilmeDTO>(filme);

        patch.ApplyTo(filmeParaAtualizar, ModelState);

        if (!TryValidateModel(filmeParaAtualizar))
        {
            return ValidationProblem(); // se não for válido retorna um problema de validação
        }
        else
        {
            _mapper.Map(filmeParaAtualizar, filme);
            _context.SaveChanges();
            return NoContent();
        }
        //         { modelo do json usado no patch
        //            "op": "replace", // operaçãp
        //    "path": "/titulo", // campo que será atualizado
        //    "value": "Avatar" // valor
        //}

        // link usado no patch https://localhost:7190/Filme/2

        // método para fazer a atualização do método, o mesmo atualiza os
        // dados, o mesmo faz a atualização de dados parciais
        // para fazer isso vamos precisar NewTonsoft


    }
    [HttpDelete("{id}")]
    public IActionResult DeletaFilme(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        _context.Remove(filme);
        _context.SaveChanges();
        return NoContent();
    }
}
