using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneManager
{
    public class Phone
    {
        private List<string> specs = new List<string>();

        public List<string> Specs { get { return specs; } set { specs = value; } }
    }
}
