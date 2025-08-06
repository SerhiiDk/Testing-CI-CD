using POC_CI_CD.Data;
using POC_CI_CD.Entities;

namespace POC_CI_CD.UserService
{

    public interface IUserService
    {
       Task<User> GetUsers(CancellationToken cancellationToken);
       Task CreateUser(User user, CancellationToken cancellationToken);
    }
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Task CreateUser(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUsers(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
