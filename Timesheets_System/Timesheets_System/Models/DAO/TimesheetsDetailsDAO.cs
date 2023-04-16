using Dapper;
using Microsoft.Office.Interop.Excel;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Timesheets_System.Models.DTO;

namespace Timesheets_System.Models.DAO
{
    public class TimesheetsDetailsDAO
    {
        private readonly IDbConnection _dbConnection;

        public TimesheetsDetailsDAO()
        {
            _dbConnection = new NpgsqlConnection(CONSTANTS.CONNECTIONSTRING);
        }

        public TimesheetsDetailsDTO GetDetailsByFullnameAndDate(TimesheetsDetailsDTO _timsheetsDetailsDTO)
        {
            string query = @"SELECT working_hours " +
                                    "FROM timesheets_details_tb " +
                                    "WHERE fullname = @fullname AND date = @date";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("fullname", _timsheetsDetailsDTO.Fullname);
            parameters.Add("date", _timsheetsDetailsDTO.Date);

            return _dbConnection.QueryFirstOrDefault<TimesheetsDetailsDTO>(query, parameters);
        }
    }
}
