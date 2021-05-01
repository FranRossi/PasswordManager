using System;
using System.Collections.Generic;
using Obligatorio1_DA1.Utilities;
using Obligatorio1_DA1.Exceptions;
using System.Linq;

namespace Obligatorio1_DA1.Domain
{
    public class PasswordManager
    {
        private List<User> _users;
        private List<Password> _passwords;
        private List<CreditCard> _creditCards;

        public PasswordManager()
        {
            _users = new List<User>();
            _passwords = new List<Password>();
            _creditCards = new List<CreditCard>();
        }

        public void CreateUser(string name, string password)
        {
            User newUser = new User(name, password);
            if (_users.Exists(user => user.Name == name))
                throw new UsernameAlreadyTakenException();

            _users.Add(newUser);
        }

        public Boolean Login(string name, string password)
        {
            foreach (User user in _users)
                if (user.Name == name)
                    if (user.Pass == password)
                        return true;
                    else
                        return false;
            return false;
        }

        public void CreatePassword(Password password)
        {
            this._passwords.Add(password);
        }
      
        public void CreateCreditCard(CreditCard creditCard)
        {
            this._creditCards.Add(creditCard);
        }

        public List<Password> GetPasswords(User user)
        {
            return this._passwords.Where(pass => pass.User == user).ToList();
        }

        public List<Password> GetSharedPasswords(User user)
        {
            return this._passwords.Where(pass => pass.ShareWith.Contains(user)).ToList();
        }

        public void DeletePassword(Password password)
        {
            this._passwords.Remove(password);
        }

        public List<Item> GetBreachedItems(string dataBreach, User currentUser)
        {
            List<Item> breachedItems = new List<Item>();
            string[] splittedDataBreach = dataBreach.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < splittedDataBreach.Length; i++)
            {
                foreach (Password pass in _passwords)
                    if (pass.Pass == splittedDataBreach[i] && pass.User == currentUser)
                        breachedItems.Add(pass);
                foreach (CreditCard card in _creditCards)
                    if (card.Number == splittedDataBreach[i] && card.User == currentUser)
                        breachedItems.Add(card);
            }
            return breachedItems;
        }
    }
}