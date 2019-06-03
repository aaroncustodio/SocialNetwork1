using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Business
{
    class UserManagement
    {
        List<User> Users = new List<User>();
        public void AddUser(int id, string name, string gender, DateTime birthday, string email)
        {
            Users.Add(new User
            {
                ID = id,
                Name = name,
                Gender = gender,
                Birthday = birthday,
                Email = email,
                DateCreated = DateTime.Now
            });
        }

        public void DeleteUser(int id)
        {
            Users.RemoveAll(a => a.ID == id);
        }
    }
}
