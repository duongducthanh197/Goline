using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheets_System.Models.DAO;
using Timesheets_System.Models.DTO;


namespace Timesheets_System.Controllers
{

    public class UserController
    {
        UserDAO _userDAO = new UserDAO();

        public UserDTO GetUserByID(string username)
        {
            return _userDAO.GetUserByID(username);
        }

        public UserDTO GetUserByFullname(string fullname)
        {
            return _userDAO.GetUserByFullname(fullname);
        }
}
}
