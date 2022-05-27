using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneManager
{
    /// <summary>
    /// Custom class med to send multiple paramters as one object to go around the limited parameter count in WinUI 3 for page to page navigation
    /// </summary>
    public class Params
    {
        private List<List<string>> data = new List<List<string>>();

        public List<List<string>> Data { get { return data; } set { data = value; } }

        private string phone;

        public string Phone { get { return phone; } set { phone = value; } }
    }
}
