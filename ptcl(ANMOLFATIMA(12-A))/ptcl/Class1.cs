using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class Class
    {
        public SqlConnection sqlcon = new SqlConnection();
        public void conString()
        {
            sqlcon.ConnectionString = @"Server=.\SQL2014;User Instance = true; AttachDbFilename=|DataDirectory|PTCL1.mdf;Database=PTCL1; Trusted_Connection=Yes;";
        }
    }
}
