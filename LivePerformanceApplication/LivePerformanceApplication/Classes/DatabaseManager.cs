using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceApplication.Exceptions;
using Oracle.DataAccess.Client;

namespace LivePerformanceApplication.Classes
{
    public static class DatabaseManager
    {
        private static readonly string _strConnection =
            "Data Source=//fhictora01.fhict.local:1521/fhictora;Persist Security Info=True;User Id=dbi278048;Password=password";

        /// <summary>
        /// Database connection; uses _strConnection
        /// </summary>
        private static readonly OracleConnection _connection = new OracleConnection(_strConnection);

        /// <summary>
        /// Creates the command with sql query and database connection information
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private static OracleCommand CreateOracleCommand(string sql)
        {
            OracleCommand command = new OracleCommand(sql, _connection);
            command.CommandType = System.Data.CommandType.Text;

            return command;
        }

        /// <summary>
        ///  Opens the connection with the database, returns the reader
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        private static OracleDataReader ExecuteQuery(OracleCommand command)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        _connection.Open();
                    }
                    catch (OracleException exc)
                    {
                        Debug.WriteLine("Database connection failed!\n" + exc.Message);
                        throw;
                    }
                }

                OracleDataReader reader = command.ExecuteReader();

                return reader;
            }
            catch (OracleException)
            {
                return null;
            }
        }

        /// <summary>
        /// Opens the connection with the database and inserts the given information, returns true if insert worked
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        private static bool ExecuteNonQuery(OracleCommand command)
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        _connection.Open();
                    }
                    catch (OracleException exc)
                    {
                        Debug.WriteLine("Database connection failed!\n" + exc.Message);
                        throw;
                    }
                }

                command.ExecuteNonQuery();
                return true;
            }
            catch (OracleException)
            {
                return false;
            }
        }

        /// <summary>
        /// Tests the connection to the database
        /// </summary>
        public static void TestConnection()
        {
            try
            {
                using (_connection)
                {
                    _connection.Open();
                    _connection.Close();
                }
            }
            catch (Exception exc)
            {
                throw new DatabaseNotConnectedException(exc.Message);
            }
        }
    }
}
