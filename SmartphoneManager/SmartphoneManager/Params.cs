using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneManager
{
    public class Params
    {
        private List<List<string>> data = new List<List<string>>();

        public List<List<string>> Data { get { return data; } set { data = value; } }

        private string phone;

        public string Phone { get { return phone; } set { phone = value; } }
    }
}
