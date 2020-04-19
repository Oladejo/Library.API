using AutoMapper;
using Library.DTO;
using Library.Entities;

namespace Library.ProfileMapping
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookWithConcatenatedAuthorName>()
                .ForMember(desk => desk.Author, opt => opt.MapFrom(src =>
                $"{src.Author.FirstName} {src.Author.LastName}"));


            CreateMap<Book, BookDTO>()
                .ForMember(dest => dest.AuthorFirstName, opt => opt.MapFrom(src =>
                $"{src.Author.FirstName}"))
                .ForMember(dest => dest.AuthorLastName, opt => opt.MapFrom(src =>
                $"{src.Author.LastName}"));

            CreateMap<BookForCreation, Book>();

            CreateMap<BookForCreationWithAmountOfPages, Book>();
        }
    }
}
