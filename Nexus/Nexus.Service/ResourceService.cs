using Nexus.Data.Infrastructure;
using Nexus.Data.Repositories;
using Nexus.Model;

namespace Nexus.Service
{
    public interface IResourceService
    {
        IEnumerable<Resource> GetAllResources();
        Resource GetResource(int id);
        Resource GetResourceByCode(string code);
        void CreateResource(Resource resource);
        void SaveResource();
    }

    public class ResourceService : IResourceService
    {
        private readonly IResourceRepository _resourceRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ResourceService(IResourceRepository resourceRepository, IUnitOfWork unitOfWork)
        {
            _resourceRepository = resourceRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Resource> GetAllResources()
        {
            return _resourceRepository.GetAll();
        }

        public Resource GetResource(int id)
        {
            return _resourceRepository.GetById(id);
        }

        public Resource GetResourceByCode(string code)
        {
            return _resourceRepository.GetByCode(code);
        }

        public void CreateResource(Resource resource)
        {
            _resourceRepository.Add(resource);
        }

        public void SaveResource()
        {
            _unitOfWork.Commit();
        }
    }
}
