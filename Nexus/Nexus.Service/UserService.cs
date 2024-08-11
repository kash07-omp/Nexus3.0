using Nexus.Data.Infrastructure;
using Nexus.Data.Repositories;
using Nexus.Model;
using System.Collections.Generic;

namespace Nexus.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUser(int id);
        void CreateUser(User user);
        void SaveUser();
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public User GetUser(int id)
        {
            return _userRepository.GetById(id);
        }

        public void CreateUser(User user)
        {
            _userRepository.Add(user);
        }

        public void SaveUser()
        {
            _unitOfWork.Commit();
        }
    }
}
