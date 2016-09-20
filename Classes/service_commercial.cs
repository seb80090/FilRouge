using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Classes
{
    public class service_commercial
    {


        public int id_commercial { get; set; }
        public string prenom_commercial { get; set; }
        public string nom_commercial { get; set; }
        public string tel_commercial { get; set; }
        public string mail_commercial { get; set; }


    }
}