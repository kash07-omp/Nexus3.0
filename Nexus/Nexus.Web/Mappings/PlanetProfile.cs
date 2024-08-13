using AutoMapper;
using Nexus.Model;
using Nexus.Web.Models;

namespace Nexus.Web.Mappings
{
    public class PlanetProfile : Profile
    {
        public PlanetProfile()
        {
            CreateMap<Planet, PlanetViewModel>().ReverseMap();
        }
    }
}