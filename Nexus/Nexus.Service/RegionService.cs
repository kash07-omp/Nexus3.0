using Nexus.Data.Infrastructure;
using Nexus.Data.Repositories;
using Nexus.Model;
using System.Collections.Generic;

namespace Nexus.Service
{
    public interface IRegionService
    {
        IEnumerable<Region> GetAllRegions();
        Region GetRegion(int id);
        void CreateRegion(Region region);
        void SaveRegion();
    }

    public class RegionService : IRegionService
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RegionService(IRegionRepository regionRepository, IUnitOfWork unitOfWork)
        {
            _regionRepository = regionRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Region> GetAllRegions()
        {
            return _regionRepository.GetAll();
        }

        public Region GetRegion(int id)
        {
            return _regionRepository.GetById(id);
        }

        public void CreateRegion(Region region)
        {
            _regionRepository.Add(region);
        }

        public void SaveRegion()
        {
            _unitOfWork.Commit();
        }
    }
}
