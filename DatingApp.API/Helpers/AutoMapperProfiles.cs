using AutoMapper;
using DatingApp.API.DTO;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDTO>();
            CreateMap<User, UserForDetailedDTO>();
            CreateMap<Photo, PhotosForDetailedDTO>();
        }
    }
}