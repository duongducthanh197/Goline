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

namespace Timesheets_System.Models.DAO
{
    public class UserDAO
    {
        private readonly IDbConnection _dbConnection;

        public UserDAO()
        {
            _dbConnection = new NpgsqlConnection(CONSTANTS.CONNECTIONSTRING);
        }

        public UserDTO getUserByID(string userID)
        {
            String query = "SELECT * FROM user_tb WHERE LOWER(username) = LOWER(@userID)";
            var parameters = new DynamicParameters();
            parameters.Add("userID", userID);

            return _dbConnection.QueryFirstOrDefault<UserDTO>(query, parameters);
        }
    }
}
