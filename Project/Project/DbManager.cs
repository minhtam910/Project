using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    class DbManager
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        public DbManager(string conString)
        {
            this.conn = new SqlConnection(conString);
        }

        public DataSet selectCommand(string select, SqlParameter[] p)
        {
            conn.Open();
            cmd = new SqlCommand(select, conn);
            if (p.Length >0)
                cmd.Parameters.AddRange(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }
    }
}
