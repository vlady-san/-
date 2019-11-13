using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example_04.Homework.FirstOrmLibrary;
using Example_04.Homework.Models;

namespace Example_04.Homework.Clients
{
    class FirstOrm : IOrmAdapter
    {
        private IFirstOrm<DbUserEntity> _firstOrm1;
        private IFirstOrm<DbUserInfoEntity> _firstOrm2;

        public DbUserEntity GetUser(int userId)
        {
            var user = _firstOrm1.Read(userId);
            return user;
        }

        public DbUserInfoEntity GetUserData(int u_InfoId)
        {
            var userInfo = _firstOrm2.Read(u_InfoId);
            return userInfo;
        }

        public void AddUser(DbUserEntity user)
        {
            _firstOrm1.Add(user);
        }

        public void AddUserData(DbUserInfoEntity userInfo)
        {
            _firstOrm2.Add(userInfo);
        }

        public void DeleteUser(int userId)
        {
            var user = _firstOrm1.Read(userId);
            _firstOrm1.Delete(user);
        }

        public void DeleteUserData(int userId)
        {
            var user = _firstOrm1.Read(userId);
            var userInfo = _firstOrm2.Read(user.InfoId);

            _firstOrm2.Delete(userInfo);
        }
    }
}