using System.Collections.Generic;

namespace CmsIocCore.Models
{
    public interface IMyLogger
    {
        void Log();
    }

    class Logger : IMyLogger
    {
        public void Log()
        {
            
        }
    }

    public interface IUserRepository
    {
        List<string> GetAll();
    }

    class UserRepository : IUserRepository
    {
        private readonly IMyLogger _logger;

        public UserRepository(IMyLogger logger)
        {
            _logger = logger;
        }

        public List<string> GetAll()
        {
            return new List<string> { "Toppen", "Boppen" };
        }
    }
}