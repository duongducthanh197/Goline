using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheets_System.Models.DTO;

namespace Timesheets_System.Models.DAO
{
    public class TimesheetsRawDataDAO
    {
        private readonly IDbConnection _dbConnection;

        public TimesheetsRawDataDAO()
        {
            _dbConnection = new NpgsqlConnection(CONSTANTS.CONNECTIONSTRING);
        }


        public void InsertTimesheetsRawData(List<TimesheetsRawDataDTO> rawData)
        {
            string query = "INSERT INTO Timesheets_raw_data_tb(fullname, in_out_time) VALUES (@Fullname, @In_Out_Time)";
            _dbConnection.Execute(query, rawData);
        }
    }
}
