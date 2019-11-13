using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example_04.Homework.Models;
using Example_04.Homework.SecondOrmLibrary;

namespace Example_04.Homework.Clients
{
    class SecondOrm : IOrmAdapter
    {
        private ISecondOrm _secondOrm;

        public DbUserEntity GetUser(int userId)
        {
            var user = _secondOrm.Context.Users.First(i => i.Id == userId);
            return user;
        }

        public DbUserInfoEntity GetUserData(int u_InfoId)
        {
            var userInfo = _secondOrm.Context.UserInfos.First(i => i.Id == u_InfoId);
            return userInfo;
        }

        public void AddUser(DbUserEntity user)
        {
            _secondOrm.Context.Users.Add(user);
        }

        public void AddUserData(DbUserInfoEntity userInfo)
        {
            _secondOrm.Context.UserInfos.Add(userInfo);
        }

        public void DeleteUser(int userId)
        {
            var user = _secondOrm.Context.Users.First(i => i.Id == userId);

            _secondOrm.Context.Users.Remove(user);
        }

        public void DeleteUserData(int userId)
        {
            var user = _secondOrm.Context.Users.First(i => i.Id == userId);
            var userInfo = _secondOrm.Context.UserInfos.First(i => i.Id == user.InfoId);

            _secondOrm.Context.UserInfos.Remove(userInfo);
        }
    }
}