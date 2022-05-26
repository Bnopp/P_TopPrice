using Microsoft.UI.Xaml.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace SmartphoneManager
{
    internal class Data
    {
        private MySqlConnection _mySqlConnection;
        private bool _connected;

        public bool Connected { get { return _connected; } }

        public Data()
        {
            _connected = false;
        }

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

        public List<Phone> GetPhones(string search, string sort, object brand, object os)
        {
            string query = "SELECT * FROM t_smartphone WHERE smaModel LIKE '%" + search + "%' ";

            ComboBox cbBrand = (brand as ComboBox);
            ComboBox cbOs = (os as ComboBox);

            if (cbBrand.SelectedItem != null)
            {
                query += "AND fkBrand = " + GetOneBrand(cbBrand.SelectedItem.ToString(), false)[0] + " ";
            }

            if (cbOs.SelectedItem != null)
            {
                query += "AND fkOS = " + GetOneOS(cbOs.SelectedItem.ToString(), false)[0] + " ";
            }

            if (sort == "PRIX CROISSANT")
                query += "ORDER BY `t_smartphone`.`smaPrice` ASC ";
            else if (sort == "PRIX DÉCROISSANT")
                query += "ORDER BY `t_smartphone`.`smaPrice` DESC ";
            else if (sort == "Taille Écran CROISSANT")
                query += "ORDER BY `t_smartphone`.`smaScreenSize` ASC ";
            else
                query += "ORDER BY `t_smartphone`.`smaScreenSize` DESC ";

            query += ";";

            //System.Diagnostics.Debug.WriteLine(query);

            List<Phone> list = new List<Phone>();

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
