namespace Example_04.Homework.Clients
{
    public interface IOrmAdapter
    {
        DbUserEntity GetUser(int userId);
        DbUserInfoEntity GetUserData(int u_nfoId);
        void AddUser(DbUserEntity user);
        void AddUserData(DbUserInfoEntity userInfo);
        void DeleteUser(int userId);
        void DeleteUserData(int userId);
    }
}
