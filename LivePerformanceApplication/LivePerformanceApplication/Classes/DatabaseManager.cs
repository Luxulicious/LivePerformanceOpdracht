using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformanceApplication.Classes.SharedModels;
using LivePerformanceApplication.Exceptions;
using Oracle.DataAccess.Client;

namespace LivePerformanceApplication.Classes
{
    public static class DatabaseManager
    {
        private static readonly string _strConnection =
            "Data Source=//fhictora01.fhict.local:1521/fhictora;Persist Security Info=True;User Id=dbi278048;Password=password";

        //private static readonly string _strConnection =
        //"Data Source=//localhost:1521/fhictora;Persist Security Info=True;User Id=dbi278048;Password=password";




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

        public static Gebruiker GetGebruiker(string email, string wachtwoord)
        {
            try
            {
                using (_connection)
                {
                    var cmd = CreateOracleCommand("SELECT GebruikerId, Naam, Email, Wachtwoord FROM GEBRUIKER WHERE Email = :Email AND Wachtwoord = :Wachtwoord");
                    cmd.Parameters.Add("Email", email);
                    cmd.Parameters.Add("Wachtwoord", wachtwoord);
                    var reader = ExecuteQuery(cmd);
                    while (reader.Read())
                    {
                        var mail = reader["Email"].ToString();
                        var naam = reader["Naam"].ToString();
                        int gebruikerId = -1;
                        if (!string.IsNullOrEmpty(reader["GebruikerId"].ToString()))
                            gebruikerId = Convert.ToInt32(reader["GebruikerId"]);
                        var password = reader["Wachtwoord"].ToString();
                        if (!string.IsNullOrEmpty(password))
                            return new Gebruiker(gebruikerId, mail, naam, true);
                        return null;
                    }
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal static bool AddMeer(string naam, double prijs, List<IBoot> boten)
        {
            try
            {
                bool succes = true;
                using (_connection)
                {
                    var cmd = CreateOracleCommand("INSERT INTO MEER (Naam, Prijs) VALUES (:Naam, :Prijs");
                    cmd.Parameters.Add("Naam", naam);
                    cmd.Parameters.Add("Prijs", prijs);
                    succes = ExecuteNonQuery(cmd);
                    cmd = CreateOracleCommand("SELECT MAX(MeerId) FROM MEER");
                    int meerId = -1;
                    var reader = ExecuteQuery(cmd);
                    {
                        if (!string.IsNullOrEmpty(reader["MeerId"].ToString()))
                            meerId = Convert.ToInt32(reader["MeerId"].ToString());
                    }

                    foreach (var boot in boten)
                    {
                        cmd = CreateOracleCommand("INSERT INTO BOOTVERBOD (BootId, MeerId) VALUES (:BootId, :MeerId)");
                        cmd.Parameters.Add("MeerId", meerId);
                        cmd.Parameters.Add("BootId", boot.Id);
                        succes = ExecuteNonQuery(cmd);
                    }
                    return succes;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<IBoot> GetBoten()
        {
            try
            {
                var boten = new List<IBoot>();
                using (_connection)
                {
                    var cmd = CreateOracleCommand("SELECT BOOT.BootId, Naam, Prijs, BOOT.SoortBoot, Tankinhoud " +
                                                  "FROM BOOT INNER JOIN MOTORBOOT ON BOOT.BootId = MOTORBOOT.BootId");
                    var reader = ExecuteQuery(cmd);
                    while (reader.Read())
                    {
                        int bootId = -1;
                        if (!string.IsNullOrEmpty(reader["BootId"].ToString()))
                            bootId = Convert.ToInt32(reader["BootId"].ToString());
                        var naam = reader["Naam"].ToString();
                        double prijs = -1.00;
                        if (!string.IsNullOrEmpty(reader["Prijs"].ToString()))
                            prijs = Convert.ToDouble(reader["Prijs"].ToString());
                        var soortBoot = reader["SoortBoot"].ToString();
                        double tankInhoud = -1.00;
                        if (!string.IsNullOrEmpty(reader["Tankinhoud"].ToString()))
                            tankInhoud = Convert.ToDouble(reader["Tankinhoud"].ToString());
                        boten.Add(new Motorboot(bootId, naam, prijs, soortBoot, tankInhoud));
                    }

                    cmd = CreateOracleCommand("SELECT BOOT.BootId, Naam, Prijs, BOOT.SoortBoot FROM BOOT WHERE BOOT.SoortBoot != 'kruiser' AND Boot.SoortBoot != 'motorboot'");
                    reader = ExecuteQuery(cmd);
                    while (reader.Read())
                    {
                        int bootId = -1;
                        if (!string.IsNullOrEmpty(reader["BootId"].ToString()))
                            bootId = Convert.ToInt32(reader["BootId"].ToString());
                        var naam = reader["Naam"].ToString();
                        double prijs = -1.00;
                        if (!string.IsNullOrEmpty(reader["Prijs"].ToString()))
                            prijs = Convert.ToDouble(reader["Prijs"].ToString());
                        var soortBoot = reader["SoortBoot"].ToString();
                        boten.Add(new Spierboot(bootId, naam, prijs, soortBoot));
                    }
                    return boten;
                }
            }
            catch
            {
                return new List<IBoot>();
            }
        }
    }

}
