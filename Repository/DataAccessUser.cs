using Obligatorio1_DA1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataAccessUser
    {
        public void Add(User newUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }

        public User Login(string userName, string userPassword)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                User loggedInUser = context.Users.Include("Categories").FirstOrDefault(u => u.MasterName == userName && u.MasterPass == userPassword);
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
                /*Password passwordFromDB = context.Passwords.Include("SharedWith").FirstOrDefault(pass => pass.Id == pPasswordToShare.Id);
                pPasswordToShare.ShareWithUser(pUserShareTo);
                context.Users.Attach(pUserShareTo);
                context.SaveChanges();*/

                context.Database.ExecuteSqlCommand("INSERT INTO SharedPasswordUser(PasswordId, UserSharedWithName) " +
                                                    "VALUES ('" + passwordToShare.Id + "', '" + userShareTo.MasterName + "')");
                context.SaveChanges();
            }
        }

        public void UnSharePassword(Password passwordToShare, User userShareTo)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                /*Password passwordFromDB = context.Passwords.Include("SharedWith").FirstOrDefault(pass => pass.Id == pPasswordToShare.Id);
                pPasswordToShare.UnShareWithUser(pUserShareTo);
                context.Users.Attach(pUserShareTo);
                context.SaveChanges();*/

                context.Database.ExecuteSqlCommand("DELETE FROM SharedPasswordUser WHERE PasswordId ='" + passwordToShare.Id + "' AND" +
                    " UserSharedWithName = '" + userShareTo.MasterName + "'");
                context.SaveChanges();
            }
        }
    }
}

