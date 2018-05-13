using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaVacinacao.Dalc
{
    interface IUserDB
    {
        User GetUserByEmail(string userEmail);

        void SaveUser(User user);

    }
}
