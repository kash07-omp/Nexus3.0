using Nexus.Data.Infrastructure;
using Nexus.Data.Repositories;
using Nexus.Model;

namespace Nexus.Service
{
    public interface IPlanetService
    {
        IEnumerable<Planet> GetAllPlanets();
        Planet GetPlanet(int id);
        void CreatePlanet(Planet planet);
        void SavePlanet();
    }

    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository _planetRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PlanetService(IPlanetRepository planetRepository, IUnitOfWork unitOfWork)
        {
            _planetRepository = planetRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Planet> GetAllPlanets()
        {
            return _planetRepository.GetAll();
        }

        public Planet GetPlanet(int id)
        {
            return _planetRepository.GetById(id);
        }

        public void CreatePlanet(Planet planet)
        {
            _planetRepository.Add(planet);
        }

        public void SavePlanet()
        {
            _unitOfWork.Commit();
        }
    }
}
