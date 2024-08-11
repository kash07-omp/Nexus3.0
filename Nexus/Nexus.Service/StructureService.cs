using Nexus.Data.Infrastructure;
using Nexus.Data.Repositories;
using Nexus.Model;
using System.Collections.Generic;

namespace Nexus.Service
{
    public interface IStructureService
    {
        IEnumerable<Structure> GetAllStructures();
        Structure GetStructure(int id);
        void CreateStructure(Structure structure);
        void SaveStructure();
    }

    public class StructureService : IStructureService
    {
        private readonly IStructureRepository _structureRepository;
        private readonly IUnitOfWork _unitOfWork;

        public StructureService(IStructureRepository structureRepository, IUnitOfWork unitOfWork)
        {
            _structureRepository = structureRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Structure> GetAllStructures()
        {
            return _structureRepository.GetAll();
        }

        public Structure GetStructure(int id)
        {
            return _structureRepository.GetById(id);
        }

        public void CreateStructure(Structure structure)
        {
            _structureRepository.Add(structure);
        }

        public void SaveStructure()
        {
            _unitOfWork.Commit();
        }
    }
}
