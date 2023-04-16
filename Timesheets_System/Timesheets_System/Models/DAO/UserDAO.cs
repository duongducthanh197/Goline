using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Dapper;
using Timesheets_System.Models.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Timesheets_System.Models.DAO
{
    public class UserDAO
    {
        private readonly IDbConnection _dbConnection;

        public UserDAO()
        {
            _dbConnection = new NpgsqlConnection(CONSTANTS.CONNECTIONSTRING);
        }

        public UserDTO GetUserByID(string username)
        {
            String query = "SELECT * FROM user_tb WHERE LOWER(username) = LOWER(@username)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("username", username);

            return _dbConnection.QueryFirstOrDefault<UserDTO>(query, parameters);
        }

        public UserDTO GetUserByFullname(string fullname)
        {
            String query = "SELECT * FROM user_tb WHERE LOWER(fullname) = LOWER(@fullname)";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("fullname", fullname);

            return _dbConnection.QueryFirstOrDefault<UserDTO>(query, parameters);
        }
    }
}
