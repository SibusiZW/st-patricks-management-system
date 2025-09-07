using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace stPatricksSys
{
    public class db
    {
        public MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;database=school");
        public MySqlCommand cmd;
    }
}
