using DataAccessInterfaces;
using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessUser : IDataAccessUser
    {
        public void Add(User newUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }

        public User Login(User userToLogIn)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                User loggedInUser = context.Users.Include("Categories").FirstOrDefault(u => u.MasterName == userToLogIn.MasterName && u.MasterPass == userToLogIn.MasterPass);
                return loggedInUser;
            }
        }

        public bool CheckUniqueness(User newUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                User userToCheck = context.Users.FirstOrDefault(u => u.MasterName == newUser.MasterName);
                bool userIsNull = userToCheck == null;
                return userIsNull;
            }
        }

        public List<User> GetUsersPassNotSharedWith(Password password)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passwordFromDB = context.Passwords.Include("SharedWith").Include("User").FirstOrDefault(pass => pass.Id == password.Id);
                List<User> usersNotSharedWith = context.Users.ToList().Except(passwordFromDB.SharedWith).ToList();
                usersNotSharedWith.Remove(passwordFromDB.User);
                return usersNotSharedWith;
            }
        }

        public List<User> GetUsersPassSharedWith(Password password)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passwordFromDB = context.Passwords.Include("SharedWith").FirstOrDefault(pass => pass.Id == password.Id);
                return passwordFromDB.SharedWith.ToList();
            }
        }

        public void SharePassword(Password passwordToShare, User userShareTo)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passwordFromDB = context.Passwords.Include("User").Include("SharedWith").FirstOrDefault(pass => pass.Id == passwordToShare.Id);
                User userFromDB = context.Users.FirstOrDefault(user => userShareTo.MasterName == user.MasterName);
                passwordFromDB.ShareWithUser(userFromDB);

                context.SaveChanges();
            }
        }

        public void UnSharePassword(Password passwordToShare, User userShareTo)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passwordFromDB = context.Passwords.Include("SharedWith").FirstOrDefault(pass => pass.Id == passwordToShare.Id);
                User userFromDB = context.Users.FirstOrDefault(user => userShareTo.MasterName == user.MasterName);
                passwordFromDB.UnShareWithUser(userFromDB);
                context.SaveChanges();
            }
        }
    }
}

