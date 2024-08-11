using Nexus.Data.Infrastructure;
using Nexus.Data.Repositories;
using Nexus.Model;
using System.Collections.Generic;

namespace Nexus.Service
{
    public interface IMineService
    {
        IEnumerable<Mine> GetAllMines();
        Mine GetMine(int id);
        void CreateMine(Mine mine);
        void SaveMine();
    }

    public class MineService : IMineService
    {
        private readonly IMineRepository _mineRepository;
        private readonly IUnitOfWork _unitOfWork;

        public MineService(IMineRepository mineRepository, IUnitOfWork unitOfWork)
        {
            _mineRepository = mineRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Mine> GetAllMines()
        {
            return _mineRepository.GetAll();
        }

        public Mine GetMine(int id)
        {
            return _mineRepository.GetById(id);
        }

        public void CreateMine(Mine mine)
        {
            _mineRepository.Add(mine);
        }

        public void SaveMine()
        {
            _unitOfWork.Commit();
        }
    }
}
