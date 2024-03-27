using AutoMapper;
using PhoneBook.Data.Dtos;

namespace PhoneBook.Profiles
{
    public class PhoneBookProfile : Profile
    {
        protected PhoneBookProfile()
        {
            CreateMap<PhoneBookDto, Models.PhoneBook>();
        }
    }
}
