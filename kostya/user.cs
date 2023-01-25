using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostya
{
    public class user
    {
        public int id { get; set; }
        public string status { get; set; }

        public user(int id, string status)
        {
            this.id = id;
            this.status = status;
        }
    }
}
