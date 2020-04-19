using AutoMapper;
using Library.DTO;
using Library.Entities;

namespace Library.ProfileMapping
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDTO>();
            CreateMap<AuthorForUpdate, Author>();
        }
    }
}
