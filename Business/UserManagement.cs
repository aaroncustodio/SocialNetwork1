using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Business
{
    class UserManagement
    {
        List<Domain.User> Users = new List<User>();
        public void AddUser(int id, string name, string gender, DateTime birthday, string email)
        {
            Users.Add(new User
            {
                ID = id,
                Name = name,
                Gender = gender,
                Birthday = birthday,
                Email = email
            });
            //Domain.User NewUser = new Domain.User
            //{
            //    ID = id,
            //    Name = name,
            //    Gender = gender,
            //    Birthday = birthday,
            //    Email = email
            //};
        }
        
        public void DeleteUser(int id)
        {
            Users.RemoveAll(a => a.ID == id);
        }
    }
}
