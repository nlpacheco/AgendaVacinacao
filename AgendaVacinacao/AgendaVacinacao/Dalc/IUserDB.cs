using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace AgendaVacinacao.Dalc
{
    public interface IUserDB
    {
        Task<User> GetUserByEmail(string userEmail);

        Task SaveUser(User user);

    }
}
