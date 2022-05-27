using Microsoft.UI.Xaml.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace SmartphoneManager
{
    /// <summary>
    /// Data class handling all the data (db connection and queries) 
    /// </summary>
    internal class Data
    {
        private MySqlConnection _mySqlConnection;
        private bool _connected;

        public bool Connected { get { return _connected; } }

        /// <summary>
        /// Default main constructor
        /// </summary>
        public Data()
        {
            _connected = false;
        }

        /// <summary>
        /// Method attempts to establish a connection with a server + database
        /// </summary>
        /// <param name="serverName">Name of the server</param>
        /// <param name="databaseName">Name of the database</param>
        /// <param name="userName">username</param>
        /// <param name="pwd">password</param>
        public void EstablishConnection(string serverName, string databaseName, string userName, string pwd)
        {
            string connectionString;

            connectionString = "SERVER = " + serverName + ";";
            if (databaseName != "")
            {
                connectionString += "DATABASE = " + databaseName + ";";
            }
            connectionString += "UID = " + userName + ";" + "PASSWORD = " + pwd + ";";

            _mySqlConnection = new MySqlConnection(connectionString);

            try
            {
                _mySqlConnection.Open();
                _connected = true;
                System.Diagnostics.Debug.WriteLine("Connexion established");
            }
            catch (Exception ex)
            {
                _connected = false;
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Query requesting a list of all operating systems from the database
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllOS()
        {
            string query = "SELECT osName FROM t_os;";

            List<string> list = new List<string>();

            if (_mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                MySqlCommand cmd = new MySqlCommand(query, _mySqlConnection);

                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    list.Add(mySqlDataReader.GetString(0));
                }

                mySqlDataReader.Close();
            }

            return list;
        }

        /// <summary>
        /// Query requesting a list of all brands from the database
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllBrands()
        {
            string query = "SELECT braName FROM t_brand;";

            List<string> list = new List<string>();

            if (_mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                MySqlCommand cmd = new MySqlCommand(query, _mySqlConnection);

                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    list.Add(mySqlDataReader.GetString(0));
                }

                mySqlDataReader.Close();
            }

            return list;
        }

        /// <summary>
        /// Main query that build itself depending on parameters, outputs results in a list accordinbly
        /// </summary>
        /// <param name="search"></param>
        /// <param name="top"></param>
        /// <param name="sort"></param>
        /// <param name="brand"></param>
        /// <param name="os"></param>
        /// <param name="classify"></param>
        /// <returns></returns>
        public List<Phone> GetPhones(string search, string top, object sort, object brand, object os, object classify)
        {
            string query = "SELECT * FROM t_smartphone WHERE smaModel LIKE '%" + search + "%' ";

            //since these combo boxes can have a negative selected index "-1" aka: default text, we need to pass objects in the parameters and
            //so we can check for the selected index more easily
            ComboBox cbSort = (sort as ComboBox);
            ComboBox cbBrand = (brand as ComboBox);
            ComboBox cbOs = (os as ComboBox);
            ComboBox cbClassify = (classify as ComboBox);

            //check if a brand is selected
            if (cbBrand.SelectedItem != null)
                query += "AND fkBrand = " + GetOneBrand(cbBrand.SelectedItem.ToString(), false)[0] + " ";

            //check if 
            if (cbOs.SelectedItem != null)
                query += "AND fkOS = " + GetOneOS(cbOs.SelectedItem.ToString(), false)[0] + " ";

            //checks if a class method is selected
            if (cbClassify.SelectedItem != null)
            {
                //build the query by the selected index
                if (cbClassify.SelectedItem.ToString() == "Autonomie Multimédia")
                    query += "ORDER BY `t_smartphone`.`smaBatteryLife` DESC ";
                if (cbClassify.SelectedItem.ToString() == "CPU")
                    query += "ORDER BY `t_smartphone`.`smaClockSpeed` * `t_smartphone`.`smaThreads` DESC ";
                if (cbClassify.SelectedItem.ToString() == "CPU - Taille d'écran - RAM")
                    query += "ORDER BY `t_smartphone`.`smaClockSpeed` * `t_smartphone`.`smaThreads` DESC, " +
                        "`t_smartphone`.`smaScreenSize` DESC, " +
                        "`t_smartphone`.`smaRAM` DESC ";
            }
            else if (cbSort.SelectedItem != null)
            {
                if (cbSort.SelectedItem.ToString() == "PRIX CROISSANT")
                    query += "ORDER BY `t_smartphone`.`smaPrice` ASC ";
                else if (cbSort.SelectedItem.ToString() == "PRIX DÉCROISSANT")
                    query += "ORDER BY `t_smartphone`.`smaPrice` DESC ";
                else if (cbSort.SelectedItem.ToString() == "Taille Écran CROISSANT")
                    query += "ORDER BY `t_smartphone`.`smaScreenSize` ASC ";
                else
                    query += "ORDER BY `t_smartphone`.`smaScreenSize` DESC ";
            }

            //limits the search result
            if (top != "Tout")
                query += "LIMIT " + top;

            query += ";";

            System.Diagnostics.Debug.WriteLine(query);

            List<Phone> list = new List<Phone>();

            //loop to get and save all the data from the above query
            if (_mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                MySqlCommand cmd = new MySqlCommand(query, _mySqlConnection);

                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    int count = mySqlDataReader.FieldCount;

                    while (mySqlDataReader.Read())
                    {
                        Phone phone = new Phone();

                        for (int i = 0; i < count; i++)
                        {
                            phone.Specs.Add(mySqlDataReader.GetValue(i).ToString());
                        }
                        list.Add(phone);
                    }
                }

                mySqlDataReader.Close();
            }

            return list;
        }

        /// <summary>
        /// Query to get one os, depending on the bool parameter, using an id or an os
        /// </summary>
        /// <param name="os"></param>
        /// <param name="byId"></param>
        /// <returns></returns>
        public List<string> GetOneOS(string os, bool byId)
        {
            string query = "";
            if (byId)
                query = "SELECT osName FROM t_os WHERE idOS = " + os + ";";
            else
                query = "SELECT idOS FROM t_os WHERE osName = " + '"' + os + '"' + ";";

            List<string> list = new List<string>();

            if (_mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                MySqlCommand cmd = new MySqlCommand(query, _mySqlConnection);

                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    list.Add(mySqlDataReader.GetString(0));
                }

                mySqlDataReader.Close();
            }

            return list;
        }

        /// <summary>
        /// Query to get one brand, depending on the bool parameter, using an id or an os
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="byId"></param>
        /// <returns></returns>
        public List<string> GetOneBrand(string brand, bool byId)
        {
            string query = "";
            if (byId)
                query = "SELECT braName FROM t_brand WHERE idBrand = " + brand + ";";
            else
                query = "SELECT idBrand FROM t_brand WHERE braName = " + '"' + brand + '"' + ";";

            List<string> list = new List<string>();

            if (_mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                MySqlCommand cmd = new MySqlCommand(query, _mySqlConnection);

                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    list.Add(mySqlDataReader.GetString(0));
                }

                mySqlDataReader.Close();
            }

            return list;
        }

        /// <summary>
        /// Query to get the price history of the selected phone
        /// </summary>
        /// <param name="idPhone"></param>
        /// <returns></returns>
        public List<List<string>> GetPriceHistory(string idPhone)
        {
            string query = "SELECT priAmount, priDate FROM t_pricehistory WHERE fkSmartphone = " + idPhone + " ORDER BY `t_pricehistory`.`priDate` ASC; ";

            List<List<string>> rows = new List<List<string>>();

            if (_mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                MySqlCommand cmd = new MySqlCommand(query, _mySqlConnection);

                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    int count = mySqlDataReader.FieldCount;

                    while (mySqlDataReader.Read())
                    {
                        List<string> column = new List<string>();
                        for (int i = 0; i < count; i++)
                        {
                            column.Add(mySqlDataReader.GetValue(i).ToString());
                        }
                        rows.Add(column);
                    }
                }

                mySqlDataReader.Close();
            }

            return rows;
        }
    }
}
