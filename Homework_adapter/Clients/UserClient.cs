using System.Linq;
using Example_04.Homework.FirstOrmLibrary;
using Example_04.Homework.Models;
using Example_04.Homework.SecondOrmLibrary;

namespace Example_04.Homework.Clients
{
    public class UserClient
    {
        private IOrmAdapter _ormAdapter;
        public (DbUserEntity, DbUserInfoEntity) Get(int userId)
        {
                var user = _ormAdapter.GetUser(userId); 
                var userInfo = _ormAdapter.GetUserData(user.InfoId);

                return (user, userInfo);
        }

        public void Add(DbUserEntity user, DbUserInfoEntity userInfo)
        {
            _ormAdapter.AddUser(user);
            _ormAdapter.AddUserInfo(userInfo);
        }

        public void Remove(int userId)
        {
            _ormAdapter.DeleteUserData(userId);
            _ormAdapter.DeleteUser(userId);
        }

        public UserClient(IOrmAdapter ormAdapter)
        {
            _ormAdapter = ormAdapter;
        }
    }
}
