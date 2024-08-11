using Nexus.Data.Infrastructure;
using Nexus.Data.Repositories;
using Nexus.Model;

namespace Nexus.Service
{
    public interface IRegionStructureService
    {
        IEnumerable<RegionStructure> GetRegionStructures();
        IEnumerable<RegionStructure> GetRegionStructuresByRegionId(int regionId);
        RegionStructure GetRegionStructure(int structureId, int regionId);
        void CreateRegionStructure(RegionStructure regionStructure);
        void SaveRegionStructure();
    }

    public class RegionStructureService : IRegionStructureService
    {
        private readonly IRegionStructureRepository _regionStructureRepository;
        private readonly IStructureRepository _structureRepository;
        private readonly IRegionRepository _regionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RegionStructureService(
            IRegionStructureRepository regionStructureRepository,
            IStructureRepository structureRepository,
            IRegionRepository regionRepository,
            IUnitOfWork unitOfWork)
        {
            _regionStructureRepository = regionStructureRepository;
            _structureRepository = structureRepository;
            _regionRepository = regionRepository;
            _unitOfWork = unitOfWork;
        }

       
        public IEnumerable<RegionStructure> GetRegionStructures()
        {
            var regionStructures = _regionStructureRepository.GetAll();
            foreach (var rs in regionStructures)
            {
                rs.Structure = _structureRepository.GetById(rs.StructureId);
                rs.Region = _regionRepository.GetById(rs.RegionId);
            }
            return regionStructures;
        }

        /// <summary>
        /// TODO: Hay que testear si recuperar las relaciones (region y structure) es más rápido así o como en el método GetRegionStructuresByRegionIdTEST()
        /// Hay mas codigo de ejemplo hecho por chatGPT en la region de abajo
        /// </summary>

        public IEnumerable<RegionStructure> GetRegionStructuresByRegionId(int regionId)
        {
            var regionStructures = _regionStructureRepository.GetMany(rs => rs.RegionId == regionId);
            foreach (var rs in regionStructures)
            {
                rs.Structure = _structureRepository.GetById(rs.StructureId);
                rs.Region = _regionRepository.GetById(rs.RegionId);
            }
            return regionStructures;
        }

        public IEnumerable<RegionStructure> GetRegionStructuresByRegionIdTEST(int regionId)
        {
            return _regionStructureRepository.GetManyIncluding(rs => rs.RegionId == regionId, rs => rs.Structure, rs => rs.Region);
        }

        public RegionStructure GetRegionStructure(int structureId, int regionId)
        {
            var regionStructure = _regionStructureRepository.Get(rs => rs.StructureId == structureId && rs.RegionId == regionId);
            if (regionStructure != null)
            {
                regionStructure.Structure = _structureRepository.GetById(regionStructure.StructureId);
                regionStructure.Region = _regionRepository.GetById(regionStructure.RegionId);
            }
            return regionStructure;
        }

        public void CreateRegionStructure(RegionStructure regionStructure)
        {
            _regionStructureRepository.Add(regionStructure);
        }

        public void SaveRegionStructure()
        {
            _unitOfWork.Commit();
        }

        #region TEST SPEED OF THIS METHODS
        //public IEnumerable<RegionStructure> GetAllRegionStructures()
        //{
        //    return _regionStructureRepository.GetAllIncluding(rs => rs.Structure, rs => rs.Region);
        //}

        //public IEnumerable<RegionStructure> GetRegionStructuresByRegionId(int regionId)
        //{
        //    return _regionStructureRepository.GetManyIncluding(rs => rs.RegionId == regionId, rs => rs.Structure, rs => rs.Region);
        //}

        //public RegionStructure GetRegionStructure(int structureId, int regionId)
        //{
        //    return _regionStructureRepository.GetIncluding(rs => rs.StructureId == structureId && rs.RegionId == regionId, rs => rs.Structure, rs => rs.Region);
        //}
        #endregion
    }
}
