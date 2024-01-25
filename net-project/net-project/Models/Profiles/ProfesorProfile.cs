using AutoMapper;
using net_project.Models.DTOs;

namespace net_project.Models.Profiles
{
    public class ProfesorProfile : Profile
    {
        public ProfesorProfile() 
        {
            CreateMap<GetProfesorDTO, Profesor>();
            CreateMap<Profesor, GetProfesorDTO > ();
            CreateMap<PostProfesorDTO, Profesor>();
            CreateMap<Profesor, PostProfesorDTO>();
        }
    }
}
