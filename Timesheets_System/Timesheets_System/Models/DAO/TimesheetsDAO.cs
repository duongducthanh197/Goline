using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheets_System.Models.DTO;

namespace Timesheets_System.Models.DAO
{
    public class TimesheetsDAO
    {

        private readonly IDbConnection _dbConnection;

        public TimesheetsDAO()
        {
            _dbConnection = new NpgsqlConnection(CONSTANTS.CONNECTIONSTRING);
        }

        public List<int> GetYears()
        {
            string query = @"SELECT DISTINCT year " +
                                    "FROM Timesheets_tb";

            return _dbConnection.Query<int>(query).ToList();
        }


        public List<TimesheetsDTO> GetTimesheetsList(int year, int month)
        {

            string query = @"SELECT ts.*, u.fullname, t.team_name, dept.department_name " +
                                      "FROM timesheets_tb ts " +
                                      "JOIN user_tb u ON LOWER(ts.username) = LOWER(u.username) " +
                                      "JOIN member_of_team_tb mot ON LOWER(u.username) = LOWER(mot.member_id) " +
                                      "JOIN team_tb t ON mot.team_id = t.team_id " +
                                      "JOIN department_tb dept ON t.department_id = dept.department_id " +
                                      "WHERE ts.year = @year AND ts.month = @month ";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("year", year);
            parameters.Add("month", month);

            return _dbConnection.Query<TimesheetsDTO>(query, parameters).ToList();

        }
    }
}
