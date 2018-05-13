﻿using AgendaVacinacao.Dalc;
using AgendaVacinacao.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AgendaVacinacao.DalcFile
{
    public class UserDB : IUserDB
    {
        private const string _filename = "AGVusers.json";
        GenericFileRepository<User, string> _repository = new GenericFileRepository<User, string>(_filename);

        public User GetUserByEmail(string userEmail)
        {
            return _repository.GetEntity(userEmail);
        }

        public void SaveUser(User user)
        {
            _repository.SaveEntity(user);
        }
    }
}
