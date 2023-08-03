using AutoMapper;
using FilmesApi.Data.DTOs;
using FilmesApi.Modesls;

namespace FilmesApi.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDTO, Filme>();
            CreateMap<UpdateFilmeDTO, Filme>();
            CreateMap<Filme, UpdateFilmeDTO>(); // referente ao patch
            CreateMap<Filme, ReadFilmeDTO>();
        }
    }
}
